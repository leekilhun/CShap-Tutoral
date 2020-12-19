using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exTreeView
{
    public partial class Form1 : Form
    {
        // Log Level을 지정 할 Enum
        enum enLogLevel
        {
            Info,
            Warning,
            Error,
        }

        //Dictionary<string, string> dc = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }



        #region Form Event
        /// <summary>
        /// TreeView 경로 Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTreeLoad_Click(object sender, EventArgs e)
        {
            TreeViewLoadbyPath(tviewLocation, tboxSource.Text);
        }

        /// <summary>
        /// TreeNode 펼치기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtend_Click(object sender, EventArgs e)
        {
            if (tviewLocation.SelectedNode != null)
            {
                tviewLocation.SelectedNode.ExpandAll();   // 선택한 Node 부터 하위 노드를 펼침
            }
        }

        /// <summary>
        /// TreeNode 전체 닫기 (개인적으로 노드를 선택 할 경우 바로 앞에 하위 노드를 다 닫을 수 있기 때문에 선택 노드 닫기는 필요 없다고 생각 함)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCoolapse_Click(object sender, EventArgs e)
        {
            tviewLocation.CollapseAll();
        }

        /// <summary>
        /// TreeView를 더블 클릭 할 경우 ListBox에 Node 경로를 넣어 줌 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tviewLocation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string strSelectPath = tviewLocation.SelectedNode.FullPath;

                // 선택 노드가 lboxCommand에 있을 경우 중복 등록 하지 않음
                if (lboxCommand.Items.Contains(strSelectPath))
                {
                    Log(enLogLevel.Warning, "선택 한 Folder는 이미 Command 항목에 등록 되어 있습니다.");
                    return;
                }

                lboxCommand.Items.Add(tviewLocation.SelectedNode.FullPath);
                //dc.Add(tviewLocation.SelectedNode.FullPath, tviewLocation.SelectedNode.FullPath);   // Node 경로를 바로 넣어 놓기 때문에 굳이 Dic를 사용 할 필요가 없을 듯
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// lboxCommand를 더블 클릭 했을 경우 lboxCommand에 선택 되어 있는 Item을 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lboxCommand_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lboxCommand.Items.RemoveAt(lboxCommand.SelectedIndex);
            //dc.Remove(tviewLocation.SelectedNode.FullPath); // 삭제
        }


        /// <summary>
        /// lboxCommand 클릭 했을 경우 선택 되어 있는 노드에 있는 폴더와 파일명을 가져와서 Textbox에 보여 줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lboxCommand_MouseClick(object sender, MouseEventArgs e)
        {
            if (lboxCommand.SelectedItem == null) return;   // 선택 된 아이템이 없을 경우 return

            StringBuilder sb = new StringBuilder();

            string dirPath = SourcePath();

            // Interlock Check (체크가 필요한 구간마다 넣어 주고 이상 시 Log만 호출해서 적어 주면 됨)
            if (string.IsNullOrEmpty(dirPath))
            {
                Log(enLogLevel.Warning, "Source 경로가 입력되어 있지 않습니다.");
                return;
            }

            // 해당 Folder 내에 있는 Folder와 File을 가져옴
            if (Directory.Exists(dirPath))
            {
                DirectoryInfo di = new DirectoryInfo(dirPath);

                foreach (var directory in di.GetDirectories())
                {
                    sb.Append($"[Folder] {directory} \r\n");
                }

                foreach (var file in di.GetFiles())
                {
                    sb.Append($"  {file.Name} \r\n");
                }

                tboxFile.Text = sb.ToString();
            }
        }


        /// <summary>
        /// File 복사 버튼 클릭 시 파일 복사 진행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            string sourcePath = SourcePath();    // Source Folder Full Path
            string destinationPath = $@"{tboxDestination.Text}\{DateTime.Now:yyyyMMdd_hhss}";   // File Backup용으로 지정 경로 + 날짜 + 시간 ex) c:\temp\20200410_1033

            Log(enLogLevel.Info, $"Source : {sourcePath}");
            Log(enLogLevel.Info, $"Destination : {destinationPath}");

            FileSystem.CopyDirectory(sourcePath, destinationPath, UIOption.AllDialogs);

            Log(enLogLevel.Info, $"경로 Backup을 완료 하였습니다.");
        }
        #endregion




        #region Inner Function

        /// <summary>
        /// Folder 경로를 기준으로 Tree View를 새로 그림
        /// </summary>
        /// <param name="treeView">새로 그릴 TreeView Control</param>
        /// <param name="path">Tree View를 그릴 Folder 계층을 가지고 있는 경로</param>
        private void TreeViewLoadbyPath(TreeView treeView, string path)
        {
            // Interlock Check (체크가 필요한 구간마다 넣어 주고 이상 시 Log만 호출해서 적어 주면 됨)
            if (string.IsNullOrEmpty(tboxSource.Text))
            {
                Log(enLogLevel.Warning, "Source 경로가 입력되어 있지 않습니다.");
                return;
            }

            treeView.Nodes.Clear();   // 기존의 TreeView를 초기화

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(path);  // DirectoryInfo Class를 선언

            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));  // 

            //treeView.Nodes.Add("TEST");   // TreeView에 노드를 추가
            //treeView.Nodes.Remove(treeView.SelectedNode);   // TreeView의 선택 노드를 삭제
        }

        /// <summary>
        /// Directory 경로를 TreeNode로 반환
        /// </summary>
        /// <param name="directoryInfo"></param>
        /// <returns></returns>
        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            TreeNode directoryNode = new TreeNode(directoryInfo.Name);

            //DirectoryInfo[] oTemp = directoryInfo.GetDirectories();   

            foreach (var directory in directoryInfo.GetDirectories())   // 해당 경로의 Folder명을 배열로 가져옴
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));   // 경로를 재귀 수로 계속 호출 하면서 하위 노드 들을 찾아 옴

            // File 명을 가지고 오기 위한 Node
            //foreach (var file in directoryInfo.GetFiles())
            //    directoryNode.Nodes.Add(new TreeNode(file.Name));

            return directoryNode;   // TreeNode에 하위 Node를 반환하고 다시 그 노드를 상위로 반환하고 하는 과정을 반복하면서 트리 구조의 노드를 만들어서 최상위 노드로 보냄
        }

        #endregion


        #region Log OverLoading
        private void Log(enLogLevel eLevel, string LogDesc)
        {
            DateTime dTime = DateTime.Now;
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
            lboxLog.Items.Insert(0, LogInfo);
        }
        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
            lboxLog.Items.Insert(0, LogInfo);
        }


        private string SourcePath()
        {
            string path = tboxSource.Text;
            var lastFolder = Path.GetDirectoryName(path);
            string strpath = lboxCommand.SelectedItem.ToString();   //dc[lboxCommand.SelectedItem.ToString()];

            string dirPath = $@"{lastFolder}\{strpath}";  // TextBox에 적어놓은 Local 경로와 TreeNode에서 가져온 하위 경오를 합쳐서 복사 할 폴더가 있는 경로를 만듬

            return dirPath;
        }




        #endregion


    }
}

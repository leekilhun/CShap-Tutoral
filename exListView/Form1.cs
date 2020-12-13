﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exListView
{
    public partial class Form1 : Form
    {

        static ListView listView1;
        public Form1()
        {
            InitializeComponent();
            CreateMyListView();

        }

        private void RemoveColumn()
        {
            string msg = string.Format("Column Count == {0}", listView1.Columns.Count);
            Console.WriteLine(msg);
            if(listView1.Columns.Count ==4)
            {
                listView1.Columns.RemoveAt(3);
            }
            else
            {
                listView1.Columns.Add("Add Column 1");
                listView1.Columns.Add("Add Coulum 2", 150, HorizontalAlignment.Center);
                listView1.Columns.Insert(3, "Insert Columns");


            }

        }
            
        private void CreateMyListView()
        {
            // Create a new ListView control.
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Image.FromFile("../Resource/Off_large_240.png"));
            imageListSmall.Images.Add(Image.FromFile("../Resource/On_large_240.png"));
            imageListLarge.Images.Add(Image.FromFile("../Resource/on_48.png"));
            imageListLarge.Images.Add(Image.FromFile("../Resource/off_48.png"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveColumn();

        }

        private void btnDeleteChecked_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Checked Row Count = {0}", listView1.CheckedIndices.Count);

            for (int i =listView1.CheckedIndices.Count -1; i>=0; i--)
            {
                int idx = listView1.CheckedIndices[i];
                Console.WriteLine("Remove Checked Row index = {0}", idx);
                listView1.Items.RemoveAt(idx);
            }
        }
    }
}

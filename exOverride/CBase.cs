using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace exOverride
{/// <summary>
    /// 기본 클래스
    /// </summary>
    class CBase
    {
        public string strName;
        protected Pen _Pen;

        /// <summary>
        /// 생성자
        /// </summary>
        public CBase()
        {
            _Pen = new Pen(Color.Aqua);
        }
    }
}

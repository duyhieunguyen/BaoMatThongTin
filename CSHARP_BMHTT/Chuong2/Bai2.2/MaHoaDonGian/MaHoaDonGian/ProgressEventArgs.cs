using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaDonGian
{
    class ProgressEventArgs : EventArgs
    {
        #region Khai báo biến
        int Increment;
        #endregion

        #region Các hàm tạo
        public ProgressEventArgs(int Inc)
        {
            this.Increment = Inc;
        }
        #endregion
       
    }

    class ProgressInitArgs : EventArgs
    {
        #region Khai báo biến
        int Maximum;
        #endregion

        #region Các hàm tạo
        public ProgressInitArgs(int Max)
        {
            this.Maximum = Max;
        }
        #endregion
    }


}

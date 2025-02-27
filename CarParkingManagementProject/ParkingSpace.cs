using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkingManagementProject
{
    public class ParkingSpace
    {
        private int row;
        private int column;
        private int[,] baiXe;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Column
        {
            get { return column; }
            set { column = value; }
        }
        public int[,] BaiXe
        {
            get { return baiXe; }
            set { baiXe = value; }
        }
        public ParkingSpace(int row, int column)
        {
            this.Row = row;
            this.Column = column;
            this.baiXe = new int[row, column];
        }
        public void ChangeSpace(int newRow, int newColumn)
        {
            // Tạo bãi đỗ mới với kích thước mới
            ParkingSpace newSpace = new ParkingSpace(newRow, newColumn);

            // Sao chép dữ liệu cũ vào bãi đỗ mới trong phạm vi hợp lệ
            for (int i = 0; i < Math.Min(this.row, newRow); i++)
            {
                for (int j = 0; j < Math.Min(this.column, newColumn); j++)
                {
                    newSpace.baiXe[i, j] = this.baiXe[i, j];
                }
            }

            // Cập nhật kích thước và mảng bãi đỗ
            this.row = newRow;
            this.column = newColumn;
            this.baiXe = newSpace.baiXe;
        }

        public void ShowSpace()
        {
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.column; j++)
                {
                    Console.Write(this.baiXe[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
        

    
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRNG.Forms
{
    public partial class BRNGStatistics : Form
    {
        private int errorCounter;
        private int lenghtOfSeq;

        public int ErrorsCounter
        {
            get { return errorCounter; }
            set
            {
                errorCounter = value;
                statisticDatas[0].Error = errorCounter;
                dataGrid.Refresh();
            }
        }
        public int LengthOfSeq
        {
            get { return lenghtOfSeq; }
            set
            {
                lenghtOfSeq = value;
                statisticDatas[0].Value = lenghtOfSeq;
                //dataGrid.DataSource = statisticDatas;
                dataGrid.Refresh();
            }
        }
        
        private BindingList<Data> statisticDatas;
        public BRNGStatistics(int _lenghtOfSeq)
        {
            lenghtOfSeq = _lenghtOfSeq;
            statisticDatas = new BindingList<Data>();
            InitializeComponent();
            statisticDatas.Add(new Data { Value = lenghtOfSeq, Error = 0 });
            dataGrid.DataSource = statisticDatas;
        }



    }
    public class Data
    {
        public int Value { get; set; }
        public int Error { get; set; }
    }
}

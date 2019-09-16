using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uranai
{
    public partial class FormUranai : Form
    {
        public FormUranai()
        {
            InitializeComponent();
        }

        private void ButtonUranaiStart_Click(object sender, EventArgs e)
        {
            int dateNumber;
            dateNumber = dateTimeUranai.Value.DayOfYear;  //選んだ日付から年間累積日を計算

            switch(dateNumber % 5)      //結果が5通りあるので、年間累積日を5で割った余りで結果を分岐させる
            {
                case 0:     //大吉
                    pictureBoxResult.Image = Uranai.Properties.Resources.Daikichi;
                    textResult.Text = "おめでとう！たつぽんびっぱにゃさんから、運気が良くなる壺をたったの100万円で買うことが出来そうです！";
                    break;

                case 1:     //中吉
                    pictureBoxResult.Image = Uranai.Properties.Resources.Cyuukichi;
                    textResult.Text = "やったね！たつぽんびっぱにゃさんから、恋愛成就のお守りをたったの80万円で買うことが出来そうです！";
                    break;

                case 2:     //吉
                    pictureBoxResult.Image = Uranai.Properties.Resources.Kichi;
                    textResult.Text = "まずまずですね！たつぽんびっぱにゃさんから、年利30%の株券をたったの60万円で買うことが出来そうです！";
                    break;

                case 3:     //小吉
                    pictureBoxResult.Image = Uranai.Properties.Resources.Syoukichi;
                    textResult.Text = "あらあら、あまり運気は良くないですが、たつぽんびっぱにゃさんから30万円で祈りを捧げてもらうと厄払いは出来そうです！";
                    break;

                case 4:     //凶
                    pictureBoxResult.Image = Uranai.Properties.Resources.Kyou;
                    textResult.Text = "恐ろしい未来が見えます…これを回避するには、今すぐたつぽんびっぱにゃさんの口座に200万円を振り込んで指示を仰いで下さい…";
                    break;

                default:    //バグ用のルート
                    pictureBoxResult.Image = null;
                    break;
            }




        }
    }
}

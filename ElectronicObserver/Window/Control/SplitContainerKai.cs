using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicObserver.Window.Control
{
    /// <summary>
    /// SplitContainer の AutoScale時の挙動がアレなので、ちっとでもマシに...
    /// </summary>
    public class SplitContainerKai : SplitContainer
    {
        protected SizeF totalFactor = new SizeF(1F, 1F);
        protected bool scaleChanging = false;
        protected int defaultSplitterDistance;
        protected int defaultPanel1MinSize;
        protected int defaultPanel2MinSize;

        /// <summary>
        /// 指定倍率で、コントロールを拡大縮小
        /// するはずが、ここで設定してもなぜか後で上書きされたりするので
        /// 初期値と倍率を一旦記録しておく
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="specified"></param>
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            // 初回呼び出し時
            if (scaleChanging == false)
            {
                scaleChanging = true;

                // フォームのロード完了後に値を設定するためにイベント登録
                FindForm().Load += this.SplitContainerKai_Load;

                // 初期値設定
                totalFactor = new SizeF(1F, 1F);
                defaultSplitterDistance = this.SplitterDistance;
                defaultPanel1MinSize = this.Panel1MinSize;
                defaultPanel2MinSize = this.Panel2MinSize;
            }
            
            // 拡大・縮小は複数回呼ばれる（ことがあるらしい？）ので、累積
            totalFactor = new SizeF(totalFactor.Width * factor.Width, totalFactor.Height * factor.Height);

            base.ScaleControl(factor, specified);
        }

        /// <summary>
        /// フォームのロード完了後に呼び出される
        /// 保存しておいた初期値・倍率から各値を設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplitContainerKai_Load(object sender, EventArgs e)
        {
            if(scaleChanging)
            {
                // イベント登録を解除
                FindForm().Load -= this.SplitContainerKai_Load;

                // 分轄方向から倍率を求める
                double scale = (this.Orientation == Orientation.Vertical) ? totalFactor.Width : totalFactor.Height;

                // 倍率変更があれば、値を更新
                if (scale != 1.0)
                {
                    this.Panel1MinSize = (int)Math.Round(defaultPanel1MinSize * scale);
                    this.Panel2MinSize = (int)Math.Round(defaultPanel2MinSize * scale);
                    this.SplitterDistance = (int)Math.Round(defaultSplitterDistance * scale);
                }

                scaleChanging = false;

            }
        }
    }
}

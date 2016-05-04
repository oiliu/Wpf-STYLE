using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Media;

namespace RigourTech.Football
{
	class CheckBoxIphone : CheckBox
	{
		Storyboard sbMoveToRight;
		Storyboard sbMoveToLeft;
		Storyboard sbRectangleShow;
		Storyboard sbRectangleHide;
		Rectangle ellipse;
		Rectangle rectangle;
        
        public CheckBoxIphone()
        {
            Style styleCheckBox = this.FindResource("CheckBoxStyleIP") as Style;
            if (styleCheckBox != null)
            {
                this.Style = styleCheckBox;
            }

            sbMoveToRight = this.FindResource("SB_EllipseMoveToRight") as Storyboard;
            sbMoveToLeft = this.FindResource("SB_EllipseMoveToLeft") as Storyboard;
            sbRectangleShow = this.FindResource("SB_RectangleShow") as Storyboard;
            sbRectangleHide = this.FindResource("SB_RectangleHide") as Storyboard;
        }

        public CheckBoxIphone(UserControl mainWnd)
		{
			Style styleCheckBox = mainWnd.Resources["CheckBoxStyleIP"] as Style;
			if (styleCheckBox != null)
			{
				this.Style = styleCheckBox;
			}

			sbMoveToRight = this.Template.Resources["SB_EllipseMoveToRight"] as Storyboard;
			sbMoveToLeft = this.Template.Resources["SB_EllipseMoveToLeft"] as Storyboard;
			sbRectangleShow = this.Template.Resources["SB_RectangleShow"] as Storyboard;
			sbRectangleHide = this.Template.Resources["SB_RectangleHide"] as Storyboard;
		}

		protected override void OnChecked(RoutedEventArgs e)
		{
			ellipse = this.Template.FindName("ellipse", this) as Rectangle;
			rectangle = this.Template.FindName("rectangleWhite", this) as Rectangle;
			base.OnChecked(e);
			if (sbMoveToRight != null)
			{
				sbMoveToRight.Begin(ellipse);
			}
			if (sbRectangleHide != null)
			{
				sbRectangleHide.Begin(rectangle,true);
			}
		}

		protected override void OnUnchecked(RoutedEventArgs e)
		{
			base.OnUnchecked(e);
			if (sbMoveToLeft != null)
			{
				sbMoveToLeft.Begin(ellipse);
				if (sbRectangleShow != null)
				{
					sbRectangleShow.Begin(rectangle, true);
				}
			}
		}
	}
}

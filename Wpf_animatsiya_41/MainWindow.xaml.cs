using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_animatsiya_41
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Kattalashtirish_Animatsiyasi(object sender, RoutedEventArgs e)
        {
            DoubleAnimation Kattalashtirish = new DoubleAnimation
            {
                From = 1,
                To = 2,
                Duration = TimeSpan.FromSeconds(3),
                AutoReverse = true, 
                RepeatBehavior = RepeatBehavior.Forever
            };
           

            ImageScale.BeginAnimation(ScaleTransform.ScaleXProperty, Kattalashtirish);
            ImageScale.BeginAnimation(ScaleTransform.ScaleYProperty, Kattalashtirish);
        }

        private void Windows_Loaded(object sender, RoutedEventArgs e) 
        {           

            DoubleAnimation harakatAnimatsiyasi = new DoubleAnimation
            {
                From = -400,
                To = 2000,
                Duration = TimeSpan.FromSeconds(7),
                RepeatBehavior = RepeatBehavior.Forever
            };

            Matn.BeginAnimation(LeftProperty, harakatAnimatsiyasi);
            // Matn.BeginAnimation(TopProperty, harakatAnimatsiyasi);

            DoubleAnimation radiusAnim = new DoubleAnimation
            {
                From = 0,
                To = 100,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            Tortburchak.BeginAnimation(Rectangle.RadiusXProperty, radiusAnim);
          Tortburchak.BeginAnimation(Rectangle.RadiusYProperty, radiusAnim);


            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(0, 0);
            gradientBrush.EndPoint = new Point(1, 1);

            var stop1 = new GradientStop(Colors.Red, 0);
            var stop2 = new GradientStop(Colors.Blue, 1);

            gradientBrush.GradientStops.Add(stop1);
            gradientBrush.GradientStops.Add(stop2);
            Tortburchak.Fill = gradientBrush;

            var colorAnim1 = new ColorAnimation
            {
                From = Colors.Red,
                To = Colors.Orange,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            var colorAnim2 = new ColorAnimation
            {
                From = Colors.Blue,
                To = Colors.Purple,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            stop1.BeginAnimation(GradientStop.ColorProperty, colorAnim1);
            stop2.BeginAnimation(GradientStop.ColorProperty, colorAnim1);
        }
    }
}

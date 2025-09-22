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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Construction;

namespace Practica7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Builder builder;
        public MainWindow()
        {
            InitializeComponent();

            builder = new Builder();
        }

        private void Method1Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double roomWidth = double.Parse(RoomWidth.Text);
                double roomLength = double.Parse(RoomLength.Text);
                double roomHeigth = double.Parse(RoomHeight.Text);
                double windowHeigth = double.Parse(WindowHeight.Text);
                double windowWidth = double.Parse(WindowWidth.Text);
                double doorframeWidth = double.Parse(DoorframeWidth.Text);
                double doorframeHeight = double.Parse(DoorframeHeight.Text);
                double wallpaperWidth = double.Parse(WallpaperWidth.Text);

                double result = builder.PasteWallpaper(roomHeigth, roomWidth, roomLength, windowHeigth, windowWidth, doorframeHeight, doorframeWidth, wallpaperWidth);
                Method1.Text = $"Рулонов нужно: {result}";
            }
            catch { }
        }

        private void Method2Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double roomWidth = double.Parse(RoomWidth.Text);
                double roomLength = double.Parse(RoomLength.Text);
                double linoleum = double.Parse(Linoleum.Text);
                double result = builder.LayLinoleum(roomWidth, roomLength, linoleum);
                Method2.Text = $"Линолеума нужно: {result}";
            }
            catch { }
        }

        private void Method3Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double roomWidth = double.Parse(RoomWidth.Text);
                double roomLength = double.Parse(RoomLength.Text);
                double paintConsumation = double.Parse(PaintConsumption.Text);
                double canVolume = double.Parse(CanVolume.Text);
                double result = builder.CeilingPainting(roomWidth, roomLength, paintConsumation, canVolume);
                Method3.Text = $"Банок краски надо: {result}";
            }
            catch { }
        }
    }
}

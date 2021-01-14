using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3DmodelShow
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //模型导入器
            ModelImporter modelImporter = new ModelImporter();


            //设置材料颜色
            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.AliceBlue));
            modelImporter.DefaultMaterial = material;

            //三维模型导入
            Model3D pier = modelImporter.Load(@"..\..\OBJfILE\Pier.obj");


            //和modelview设置binding
            Binding binding = new Binding() { Source = pier };
            this.helixviewport.SetBinding(HelixViewport3D.DataContextProperty, binding);

        }
    }
}

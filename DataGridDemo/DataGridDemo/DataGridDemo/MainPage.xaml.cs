using Syncfusion.Data;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataGridDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //private Datas MyCollect;
        
        public MainPage()
        {
            InitializeComponent();

            this.dataGrid.GridStyle = new CustomStyle();
        }
    }

    public class CustomStyle : DataGridStyle
    {
        public override ImageSource GetGroupCollapseIcon()
        {
            return null;
        }

        public override ImageSource GetGroupExpanderIcon()
        {
            return null;
        }

        public override Color GetIndentBackgroundColor(RowType rowType)
        {
            return Color.White;
        }
    }



    public class GroupCaptionConverter : IValueConverter
    {
        public string Name { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = value != null ? value as Group : null;
            if (data != null)
            {
                SfDataGrid dataGrid = (SfDataGrid)parameter;
                if ((value as Group).Parent is TopLevelGroup)
                {
                    return dataGrid.View.TopLevelGroup.GetGroupCaptionText( (value as Group), "{ColumnName} : {Key} - {ItemsCount} Items", dataGrid.GroupColumnDescriptions[0].ColumnName);
                }
                else
                {
                    return dataGrid.View.TopLevelGroup.GetGroupCaptionText((value as Group), "{ColumnName} : {Key} - {ItemsCount} Items", dataGrid.GroupColumnDescriptions[1].ColumnName);
                }
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }


    public class GroupBackgroundColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = value != null ? value as Group : null;
            if (data != null)
            {
                SfDataGrid dataGrid = (SfDataGrid)parameter;
                if ((value as Group).Parent is TopLevelGroup)
                {
                    return "LightGray";
                }
                else
                {
                    return "LightBlue";
                }
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class GroupIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = value != null ? value as Group : null;
            if (data != null)
            {
                SfDataGrid dataGrid = (SfDataGrid)parameter;
                if ((value as Group).Parent is TopLevelGroup)
                {
                    return "plus_icon_black.png";
                }
                else
                {
                    return "plus_icon_green.png";
                }
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }


}

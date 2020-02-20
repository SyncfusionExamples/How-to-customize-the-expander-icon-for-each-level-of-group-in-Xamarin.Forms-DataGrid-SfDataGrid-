# How to customize the expander icon for each level of group in Xamarin.Forms DataGrid SfDataGrid 

## About the sample

This example illustrates how to customize the expander icon of the group in SfDataGrid.

By default, DataGrid having same expander icon for all the caption summaries. But we can customize that expander icon for each group by using SfDataGrid.CaptionSummaryTemplate property. We need to set null value for GroupCollapseIcon and GroupExpanderIcon in DataGridStyle class.

```XAML
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             mc:Ignorable="d"
             x:Class="DataGridDemo.MainPage"
             xmlns:local="clr-namespace:DataGridDemo"
             xmlns:syncfusion="clr-namespace:Syncfusion.SfDataGrid.XForms;assembly=Syncfusion.SfDataGrid.XForms"
             Padding="10,10,10,10">
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:GroupCaptionConverter x:Key="SummaryConverter" />
            <local:GroupBackgroundColor x:Key="SummaryBackground" />
            <local:GroupIconConverter x:Key="SummaryIcon"></local:GroupIconConverter>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.BindingContext>
        <local:OrderInfoRepository x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfDataGrid
            x:Name="dataGrid"
             ItemsSource="{Binding OrderInfoCollection}"
             AutoGenerateColumns="False"
            AllowGroupExpandCollapse="True"
            ColumnSizer="Star"
             GroupingMode="Multiple"
             AllowEditing="True"
             NavigationMode="Cell"
             SelectionMode="Single">
            <syncfusion:SfDataGrid.GroupColumnDescriptions>
                <syncfusion:GroupColumnDescription ColumnName="OrderID" />
                <syncfusion:GroupColumnDescription ColumnName="CustomerID" />
            </syncfusion:SfDataGrid.GroupColumnDescriptions>
            <syncfusion:SfDataGrid.Columns>
                <syncfusion:GridTextColumn HeaderText="Order ID" MappingName="OrderID" />
                <syncfusion:GridTextColumn HeaderText="Customer ID" MappingName="CustomerID" />
                
                <syncfusion:GridTextColumn HeaderText="City" MappingName="ShipCity" />
                <syncfusion:GridTextColumn HeaderText="Ship Country" MappingName="ShipCountry" />
            </syncfusion:SfDataGrid.Columns>
            <syncfusion:SfDataGrid.CaptionSummaryTemplate>
                <DataTemplate>
                    <Grid Padding="5"  HorizontalOptions="CenterAndExpand" BackgroundColor="{Binding Converter={StaticResource SummaryBackground}, ConverterParameter={x:Reference dataGrid}}">

                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="Auto"></ColumnDefinition>
                            <ColumnDefinition Width="Auto"></ColumnDefinition>
                        </Grid.ColumnDefinitions>
                        <Label Grid.Column="1" x:Name="captionSummary" VerticalOptions="CenterAndExpand" WidthRequest="250"  Text="{Binding Converter={StaticResource SummaryConverter}, 
                                                  ConverterParameter = {x:Reference dataGrid} }" >

                        </Label>
                        <Image Grid.Column="0" Source="{Binding Converter={StaticResource SummaryIcon}, ConverterParameter={x:Reference dataGrid}}" VerticalOptions="Center" HorizontalOptions="End" HeightRequest="20">

                        </Image>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfDataGrid.CaptionSummaryTemplate>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>

```
 

```C#
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
```


```C#
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
```

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

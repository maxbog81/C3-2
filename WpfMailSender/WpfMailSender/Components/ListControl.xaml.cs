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
using System.Collections;

namespace WpfMailSender.Components
{
    /// <summary>
    /// Логика взаимодействия для ListControl.xaml
    /// </summary>
    public partial class ListControl : UserControl
    {
        public ListControl()
        {
            InitializeComponent();
        }

        #region PanelName : string - Название панели

        /// <summary>Название панели</summary>
        public static readonly DependencyProperty PanelNameProperty =
            DependencyProperty.Register(
                nameof(PanelName),
                typeof(string),
                typeof(ListControl),
                new PropertyMetadata(default(string)));

        /// <summary>Название панели</summary>
        public string PanelName
        {
            get => (string)GetValue(PanelNameProperty);
            set => SetValue(PanelNameProperty, value);
        }

        #endregion

        #region Items : IEnumerable - Управляемая коллекция

        /// <summary>Управляемая коллекция</summary>
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register(
                nameof(Items),
                typeof(IEnumerable),
                typeof(ListControl),
                new PropertyMetadata(default(IEnumerable)));

        /// <summary>Управляемая коллекция</summary>
        public IEnumerable Items
        {
            get => (IEnumerable)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }

        #endregion

        #region SelectedItem : object - Выбранный элемент

        /// <summary>Выбранный элемент</summary>
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
                nameof(SelectedItem),
                typeof(object),
                typeof(ListControl),
                new PropertyMetadata(default(object)));

        /// <summary>Выбранный элемент</summary>
        public object SelectedItem
        {
            get => (object)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        #endregion

        #region DisplayMemberPath : string - Имя свойства для отображения

        /// <summary>Имя свойства для отображения</summary>
        public static readonly DependencyProperty DisplayMemberPathProperty =
            DependencyProperty.Register(
                nameof(DisplayMemberPath),
                typeof(string),
                typeof(ListControl),
                new PropertyMetadata(default(string)));

        /// <summary>Имя свойства для отображения</summary>
        public string DisplayMemberPath
        {
            get => (string)GetValue(DisplayMemberPathProperty);
            set => SetValue(DisplayMemberPathProperty, value);
        }

        #endregion

        #region ItemTemplate : DataTemplate - Шаблон отображения элемента списка

        /// <summary>Шаблон отображения элемента списка</summary>
        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register(
                nameof(ItemTemplate),
                typeof(DataTemplate),
                typeof(ListControl),
                new PropertyMetadata(default(DataTemplate)));

        /// <summary>Шаблон отображения элемента списка</summary>
        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }

        #endregion

        #region AddCommand : ICommand - Команда добавления элемента

        /// <summary>Команда добавления элемента</summary>
        public static readonly DependencyProperty AddCommandProperty =
            DependencyProperty.Register(
                nameof(AddCommand),
                typeof(ICommand),
                typeof(ListControl),
                new PropertyMetadata(default(ICommand)));

        /// <summary>Команда добавления элемента</summary>
        public ICommand AddCommand
        {
            get => (ICommand)GetValue(AddCommandProperty);
            set => SetValue(AddCommandProperty, value);
        }

        #endregion

        #region EditCommand : ICommand - Команда редактирования

        /// <summary>Команда редактирования</summary>
        public static readonly DependencyProperty EditCommandProperty =
            DependencyProperty.Register(
                nameof(EditCommand),
                typeof(ICommand),
                typeof(ListControl),
                new PropertyMetadata(default(ICommand)));

        /// <summary>Команда редактирования</summary>
        public ICommand EditCommand
        {
            get => (ICommand)GetValue(EditCommandProperty);
            set => SetValue(EditCommandProperty, value);
        }

        #endregion

        #region DeleteCommand : ICommand - Команда удаления

        /// <summary>Команда удаления</summary>
        public static readonly DependencyProperty DeleteCommandProperty =
            DependencyProperty.Register(
                nameof(DeleteCommand),
                typeof(ICommand),
                typeof(ListControl),
                new PropertyMetadata(default(ICommand)));

        /// <summary>Команда удаления</summary>
        public ICommand DeleteCommand
        {
            get => (ICommand)GetValue(DeleteCommandProperty);
            set => SetValue(DeleteCommandProperty, value);
        }

        #endregion

    }
}

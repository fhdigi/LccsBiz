using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LccsBiz.Std.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewItemCustomControl : ContentView
	{
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
                                                                          propertyName: "Title",
                                                                          defaultValue: String.Empty,
                                                                          returnType: typeof(string),
                                                                          declaringType: typeof(ViewItemCustomControl),
                                                                          defaultBindingMode: BindingMode.TwoWay,
                                                                          propertyChanged: TitlePropertyChanged);

        public string Title
        {
            get { return base.GetValue(TitleProperty).ToString(); }
            set { base.SetValue(TitleProperty, value); }
        }

        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {

            var speakerControl = (ViewItemCustomControl)bindable;
            speakerControl.LabelTitle.Text = (string)newValue;
        }


        public static readonly BindableProperty SubTitleProperty = BindableProperty.Create(
                                                                           propertyName: "SubTitle",
                                                                           defaultValue: String.Empty,
                                                                           returnType: typeof(string),
                                                                           declaringType: typeof(ViewItemCustomControl),
                                                                           defaultBindingMode: BindingMode.TwoWay,
                                                                           propertyChanged: SubTitlePropertyChanged);

        public string SubTitle
        {
            get { return base.GetValue(SubTitleProperty).ToString(); }
            set { base.SetValue(SubTitleProperty, value); }
        }

        private static void SubTitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var speakerControl = (ViewItemCustomControl)bindable;
            speakerControl.LabelSubTitle.Text = (string)newValue;
        }

        public static readonly BindableProperty ImageLocationProperty = BindableProperty.Create(
                                                                           propertyName: "ImageLocation",
                                                                           defaultValue: String.Empty,
                                                                           returnType: typeof(string),
                                                                           declaringType: typeof(ViewItemCustomControl),
                                                                           defaultBindingMode: BindingMode.TwoWay,
                                                                           propertyChanged: ImageLocationPropertyChanged);

        public string ImageLocation
        {
            get { return base.GetValue(ImageLocationProperty).ToString(); }
            set { base.SetValue(ImageLocationProperty, value); }
        }

	    private static void ImageLocationPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	    {
	        var speakerControl = (ViewItemCustomControl) bindable;
	        speakerControl.ImageControl.Source = ImageSource.FromFile((string) newValue);
	    }

        public ViewItemCustomControl ()
		{
			InitializeComponent ();
		}
	}
}
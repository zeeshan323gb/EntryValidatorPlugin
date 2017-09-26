﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EntryValidator.FormsPlugin.Abstractions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailValidator : ContentView
    {
        public EmailValidator()
        {
            InitializeComponent();
        }

        #region BindableProperties
        public string Text
        {
            get { return base.GetValue(TextProperty).ToString(); }
            set { base.SetValue(TextProperty, value); }
        }

        private static BindableProperty TextProperty = BindableProperty.Create(
                                                         propertyName: "Text",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(EmailValidator),
                                                         defaultValue: "",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: TextPropertyChanged);


        private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (EmailValidator)bindable;
            control.email.Text = newValue.ToString();
        }

        public string PlaceHolder
        {
            get { return base.GetValue(PlaceHolderProperty).ToString(); }
            set { base.SetValue(PlaceHolderProperty, value); }
        }

        private static BindableProperty PlaceHolderProperty = BindableProperty.Create(
                                                         propertyName: "PlaceHolder",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(EmailValidator),
                                                         defaultValue: "Email",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: PlaceHolderPropertyChanged);


        private static void PlaceHolderPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (EmailValidator)bindable;
            control.email.Placeholder = newValue.ToString();
        }

        public string MessageError
        {
            get { return base.GetValue(MessageErrorProperty).ToString(); }
            set { base.SetValue(MessageErrorProperty, value); }
        }

        private static BindableProperty MessageErrorProperty = BindableProperty.Create(
                                                         propertyName: "MessageError",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(EmailValidator),
                                                         defaultValue: "Enter a valid email.",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: MessageErrorPropertyChanged);


        private static void MessageErrorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (EmailValidator)bindable;
            control.messagaError.Text = newValue.ToString();
        }

        public bool ShowIcon
        {
            get { return Convert.ToBoolean(GetValue(ShowIconProperty).ToString()); }
            set { base.SetValue(ShowIconProperty, value); }
        }

        private static BindableProperty ShowIconProperty = BindableProperty.Create(
                                                         propertyName: "ShowIcon",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(EmailValidator),
                                                         defaultValue: true,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ShowIconPropertyChanged);


        private static void ShowIconPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (EmailValidator)bindable;
            control.image.IsVisible = Convert.ToBoolean(newValue.ToString());
        }

        public bool ShowMessage
        {
            get { return Convert.ToBoolean(GetValue(ShowMessageProperty).ToString()); }
            set { base.SetValue(ShowMessageProperty, value); }
        }

        private static BindableProperty ShowMessageProperty = BindableProperty.Create(
                                                         propertyName: "ShowMessage",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(EmailValidator),
                                                         defaultValue: true,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ShowMessagePropertyChanged);


        private static void ShowMessagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (EmailValidator)bindable;
            control.error.IsVisible = Convert.ToBoolean(newValue.ToString());
        }

        public Color ErrorMessageColor
        {
            get { return (Color) GetValue(ErrorMessageColorProperty); }
            set { base.SetValue(ErrorMessageColorProperty, value); }
        }

        private static BindableProperty ErrorMessageColorProperty = BindableProperty.Create(
                                                         propertyName: "ErrorMessageColor",
                                                         returnType: typeof(Color),
                                                         declaringType: typeof(EmailValidator),
                                                         defaultValue: Color.Red,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ErrorMessageColorPropertyChanged);


        private static void ErrorMessageColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (EmailValidator)bindable;
            control.messagaError.TextColor = (Color) newValue;
        }


        public LayoutOptions HorizontalOptions
        {
            get { return (LayoutOptions)GetValue(HorizontalOptionsProperty); }
            set { base.SetValue(HorizontalOptionsProperty, value); }
        }

        private static BindableProperty HorizontalOptionsProperty = BindableProperty.Create(
                                                         propertyName: "HorizontalOptions",
                                                         returnType: typeof(LayoutOptions),
                                                         declaringType: typeof(EmailValidator),
                                                         defaultValue: LayoutOptions.FillAndExpand,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ShowMessagePropertyChanged);


        private static void HorizontalOptionsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (EmailValidator)bindable;
            control.email.HorizontalOptions = (LayoutOptions)newValue;
        }


        #endregion
    }
}
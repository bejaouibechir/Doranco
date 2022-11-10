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

namespace CustomControls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomControls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomControls;assembly=CustomControls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:TimePicker/>
    ///
    /// </summary>

    [TemplatePart(Name = TimePicker.ElementHourTextBox, Type = typeof(TextBox))]
    [TemplatePart(Name = TimePicker.ElementMinuteTextBox, Type = typeof(TextBox))]
    [TemplatePart(Name = TimePicker.ElementSecondTextBox, Type = typeof(TextBox))]
    [TemplatePart(Name = TimePicker.ElementIncrementButton, Type = typeof(Button))]
    [TemplatePart(Name = TimePicker.ElementDecrementButton, Type = typeof(Button))]
    public class TimePicker : Control
    {
        #region Constants

        private const string ElementHourTextBox = "PART_HourTextBox";
        private const string ElementMinuteTextBox = "PART_MinuteTextBox";
        private const string ElementSecondTextBox = "PART_SecondTextBox";
        private const string ElementIncrementButton = "PART_IncrementButton";
        private const string ElementDecrementButton = "PART_DecrementButton";

        #endregion Constants


        #region Data

        private static readonly TimeSpan MinValidTime = new TimeSpan(0, 0, 0);
        private static readonly TimeSpan MaxValidTime = new TimeSpan(23, 59, 59);

        private TextBox hourTextBox;
        private TextBox minuteTextBox;
        private TextBox secondTextBox;
        private Button incrementButton;
        private Button decrementButton;
        private TextBox selectedTextBox;

        #endregion Data


        static TimePicker()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TimePicker), new FrameworkPropertyMetadata(typeof(TimePicker)));
        }

        public TimePicker()
        {
            SelectedTime = DateTime.Now.TimeOfDay;
        }

        #region Public Properties

        #region SelectedTime

        public TimeSpan SelectedTime
        {
            get { return (TimeSpan)GetValue(SelectedTimeProperty); }
            set { SetValue(SelectedTimeProperty, value); }
        }

        public static readonly DependencyProperty SelectedTimeProperty =
            DependencyProperty.Register(
            "SelectedTime",
            typeof(TimeSpan),
            typeof(TimePicker),
            new FrameworkPropertyMetadata(TimePicker.MinValidTime, new PropertyChangedCallback(TimePicker.OnSelectedTimeChanged), new CoerceValueCallback(TimePicker.CoerceSelectedTime)));

        #endregion SelectedTime

        #region MinTime

        public TimeSpan MinTime
        {
            get { return (TimeSpan)GetValue(MinTimeProperty); }
            set { SetValue(MinTimeProperty, value); }
        }

        public static readonly DependencyProperty MinTimeProperty =
            DependencyProperty.Register(
            "MinTime",
            typeof(TimeSpan),
            typeof(TimePicker),
            new FrameworkPropertyMetadata(TimePicker.MinValidTime, new PropertyChangedCallback(TimePicker.OnMinTimeChanged)),
            new ValidateValueCallback(TimePicker.IsValidTime));

        #endregion MinTime

        #region MaxTime

        public TimeSpan MaxTime
        {
            get { return (TimeSpan)GetValue(MaxTimeProperty); }
            set { SetValue(MaxTimeProperty, value); }
        }

        public static readonly DependencyProperty MaxTimeProperty =
            DependencyProperty.Register(
            "MaxTime",
            typeof(TimeSpan),
            typeof(TimePicker),
            new FrameworkPropertyMetadata(TimePicker.MaxValidTime, new PropertyChangedCallback(TimePicker.OnMaxTimeChanged), new CoerceValueCallback(TimePicker.CoerceMaxTime)),
            new ValidateValueCallback(TimePicker.IsValidTime));

        #endregion MaxTime

        #region SelectedTimeChangedEvent

        public event RoutedPropertyChangedEventHandler<TimeSpan> SelectedTimeChanged
        {
            add { base.AddHandler(SelectedTimeChangedEvent, value); }
            remove { base.RemoveHandler(SelectedTimeChangedEvent, value); }
        }

        public static readonly RoutedEvent SelectedTimeChangedEvent =
            EventManager.RegisterRoutedEvent(
            "SelectedTimeChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<TimeSpan>),
            typeof(TimePicker));

        #endregion SelectedTimeChangedEvent

        #endregion Public Properties

        #region Public Methods

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            hourTextBox = GetTemplateChild(ElementHourTextBox) as TextBox;
            if (hourTextBox != null)
            {
                hourTextBox.IsReadOnly = true;
                hourTextBox.GotFocus += SelectTextBox;
            }

            minuteTextBox = GetTemplateChild(ElementMinuteTextBox) as TextBox;
            if (minuteTextBox != null)
            {
                minuteTextBox.IsReadOnly = true;
                minuteTextBox.GotFocus += SelectTextBox;
            }

            secondTextBox = GetTemplateChild(ElementSecondTextBox) as TextBox;
            if (secondTextBox != null)
            {
                secondTextBox.IsReadOnly = true;
                secondTextBox.GotFocus += SelectTextBox;
            }

            incrementButton = GetTemplateChild(ElementIncrementButton) as Button;
            if (incrementButton != null)
            {
                incrementButton.Click += IncrementTime;
            }

            decrementButton = GetTemplateChild(ElementDecrementButton) as Button;
            if (decrementButton != null)
            {
                decrementButton.Click += DecrementTime;
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static object CoerceSelectedTime(DependencyObject d, object value)
        {
            TimePicker timePicker = (TimePicker)d;
            TimeSpan minimum = timePicker.MinTime;
            if ((TimeSpan)value < minimum)
            {
                return minimum;
            }
            TimeSpan maximum = timePicker.MaxTime;
            if ((TimeSpan)value > maximum)
            {
                return maximum;
            }
            return value;
        }

        private static object CoerceMaxTime(DependencyObject d, object value)
        {
            TimePicker timePicker = (TimePicker)d;
            TimeSpan minimum = timePicker.MinTime;
            if ((TimeSpan)value < minimum)
            {
                return minimum;
            }
            return value;
        }

        private static bool IsValidTime(object value)
        {
            TimeSpan time = (TimeSpan)value;
            return MinValidTime <= time && time <= MaxValidTime;
        }

        protected virtual void OnSelectedTimeChanged(TimeSpan oldSelectedTime, TimeSpan newSelectedTime)
        {
            RoutedPropertyChangedEventArgs<TimeSpan> e = new RoutedPropertyChangedEventArgs<TimeSpan>(oldSelectedTime, newSelectedTime);
            e.RoutedEvent = SelectedTimeChangedEvent;
            base.RaiseEvent(e);
        }

        private static void OnSelectedTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TimePicker element = (TimePicker)d;
            element.OnSelectedTimeChanged((TimeSpan)e.OldValue, (TimeSpan)e.NewValue);
        }

        protected virtual void OnMinTimeChanged(TimeSpan oldMinTime, TimeSpan newMinTime)
        {
        }

        private static void OnMinTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TimePicker element = (TimePicker)d;
            element.CoerceValue(MaxTimeProperty);
            element.CoerceValue(SelectedTimeProperty);
            element.OnMinTimeChanged((TimeSpan)e.OldValue, (TimeSpan)e.NewValue);
        }

        protected virtual void OnMaxTimeChanged(TimeSpan oldMaxTime, TimeSpan newMaxTime)
        {
        }

        private static void OnMaxTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TimePicker element = (TimePicker)d;
            element.CoerceValue(SelectedTimeProperty);
            element.OnMaxTimeChanged((TimeSpan)e.OldValue, (TimeSpan)e.NewValue);
        }

        private void SelectTextBox(object sender, RoutedEventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void IncrementTime(object sender, RoutedEventArgs e)
        {
            IncrementDecrementTime(1);
        }

        private void DecrementTime(object sender, RoutedEventArgs e)
        {
            IncrementDecrementTime(-1);
        }

        private void IncrementDecrementTime(int step)
        {
            if (selectedTextBox == null)
            {
                selectedTextBox = hourTextBox;
            }

            TimeSpan time;

            if (selectedTextBox == hourTextBox)
            {
                time = SelectedTime.Add(new TimeSpan(step, 0, 0));
            }
            else if (selectedTextBox == minuteTextBox)
            {
                time = SelectedTime.Add(new TimeSpan(0, step, 0));
            }
            else
            {
                time = SelectedTime.Add(new TimeSpan(0, 0, step));
            }

            SelectedTime = time;
        }

        #endregion


    }
}

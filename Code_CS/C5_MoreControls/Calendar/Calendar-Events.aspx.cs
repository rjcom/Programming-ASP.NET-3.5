﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calendar_MoreSelections : Page
{ 
   protected void Page_Load(object sender, EventArgs e)     
   {        
      if (!IsPostBack)        
      {           
         Calendar1.VisibleDate = Calendar1.TodaysDate;           
         ddl.SelectedIndex = Calendar1.VisibleDate.Month - 1;        
      }        
      lblTodaysDate.Text = "Today's Date is "               
         + Calendar1.TodaysDate.ToShortDateString();     
   }
 
   protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {        
      lblSelectedUpdate();
      lblCountUpdate();        
      txtClear();
    }
     
   private void lblSelectedUpdate()    
   {       
      if (Calendar1.SelectedDate != DateTime.MinValue)          
      {
         lblSelected.Text = "The date selected is " 
            + Calendar1.SelectedDate.ToShortDateString();    
      }
   }
 
   private void lblCountUpdate()
   {
      lblCount.Text = "Count of Days Selected:  " 
         + Calendar1.SelectedDates.Count.ToString();
   }
     
   protected void ddl_SelectedIndexChanged(object sender, EventArgs e)    
   {       
      Calendar1.SelectedDates.Clear();       
      lblSelectedUpdate();       
      lblCountUpdate();       
      Calendar1.VisibleDate = new DateTime(Calendar1.VisibleDate.Year,                         
         Int32.Parse(ddl.SelectedItem.Value), 1);       
      txtClear();    
   }
     
   protected void btnTgif_Click(object sender, EventArgs e)    
   {       
      int currentMonth = Calendar1.VisibleDate.Month;       
      int currentYear = Calendar1.VisibleDate.Year;         
      Calendar1.SelectedDates.Clear();         
      for (int i = 1;                
         i <= System.DateTime.DaysInMonth(currentYear, currentMonth); i++)       
         {          
         DateTime date = new DateTime(currentYear, currentMonth, i);          
         if (date.DayOfWeek == DayOfWeek.Friday)             
         {
            Calendar1.SelectedDates.Add(date);
         }
      }
      lblSelectedUpdate();       
      lblCountUpdate();       
      txtClear();    
   }
     
   protected void btnRange_Click(object sender, EventArgs e)    
   {       
      int currentMonth = Calendar1.VisibleDate.Month;       
      int currentYear = Calendar1.VisibleDate.Year;       
      DateTime StartDate = new DateTime(currentYear, currentMonth,                            
         Int32.Parse(txtStart.Text));       
      DateTime EndDate = new DateTime(currentYear, currentMonth,                          
         Int32.Parse(txtEnd.Text));         
      Calendar1.SelectedDates.Clear();       
      Calendar1.SelectedDates.SelectRange(StartDate, EndDate);         
      lblSelectedUpdate();       
      lblCountUpdate();    
   }
    
   private void txtClear()    
   {       
      txtStart.Text = "";       
      txtEnd.Text = "";    
   }

protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
{
   //  Notice that this overrides the WeekendDayStyle.    
   if (!e.Day.IsOtherMonth && e.Day.IsWeekend)      
   {
      e.Cell.BackColor = System.Drawing.Color.LightGreen;      //  Happy New Year!    
   }
   if (e.Day.Date.Month == 1 && e.Day.Date.Day == 1)       
   {
      e.Cell.Controls.Add(new LiteralControl("<br/>Happy New Year!"));
   }
}
protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
{
    if (e.NewDate.CompareTo(e.PreviousDate) == 1)
   {
      lblMonthChanged.Text = "My future’s so bright...";
   }
   else
   {
      lblMonthChanged.Text = "Looking into the past";
   }
   Calendar1.SelectedDates.Clear(); 
   lblSelectedUpdate(); 
   lblCountUpdate(); 
   txtClear();
}
}

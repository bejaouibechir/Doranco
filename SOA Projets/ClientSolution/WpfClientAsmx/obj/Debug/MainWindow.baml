   M S B A M L   `   `   `  ????H  DWpfClientAsmx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfClientAsmxWpfClientAsmx  5   	       WpfClientAsmx.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfClientAsmx     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??0.5* ?6   ?? 5      $
??9.5* ?6   ?? 5      .+?5   
   o? $??0??6   .@?5      m? $??Products??6   .@?5      m? -   5        $
??List??5      6)   m? 5      -   5        $	??Get??5      6(   m? 5      -   5        $	??Add??5      6(   m? 5      -   5        $??Update??5      6+   m? 5      -   5        $??Delete??5      6+   m? 5      -   5        $
??Exit??5      6)   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $??productgrid??5      $??1??6&   ?? 5   
   $??2??6   5      5      
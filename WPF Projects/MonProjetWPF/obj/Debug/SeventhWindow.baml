   M S B A M L   `   `   `  ????G  CMonProjetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MonProjetWPFMonProjetWPF  5   	        MonProjetWPF.SeventhWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MonProjetWPF     5   	     ? Title$  SeventhWindow??5   	   $	??450??6   $
??1650??6,   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??3* ?6   ?? 5      $??3* ?6   .+?5   
   ?? -   5        $	??cmb??5      $??Center=?6   $??Center=?6:   $	??150??6W   ??5         MonProjetWPF.Couleurs  5      5      ?? 5   
   -   5        $
??list??5   "   $??1??6   $??Center=?6.   $??Center=?6I   $	??200??5      $	??150??5      .@?5      	?  d? 	IsChecked$
 TrueY?6   $??Rouge??6+   $??5q?6;   $??Center=?6G   $??Center=?6b   	? 5      $
??Vert??6   $??5q?6)   $??Center=?64   $??Center=?6O   	? 5      $
??Bleu??6   $??5q?6)   $??Center=?64   $??Center=?6O   5      ?? 5    
   $??2??6   $??10,10,10,10q?6#   $??3??68   ??5!      ?? 5"       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??5#      ?  ? Color$ 	#FFECEDDA??6#   ? 5$      $ 	#FFF58F85??6#    ? Offset$ 1Q?65   5%       ?? View 5'      ?? 5(       ?? AllowsColumnReorder . 	 ?? ColumnHeaderToolTip$	 Employee Information??66   .P?5)      ?? $??
Identifier??6%   ?? 5*      $??
First Name??6&   
 ?? Width$	
 100??6:   ?? 5,      $	
 100??6&   .??5-      ?? .??6/   	Last Name ? ContextMenu 5.      ?? 5/   "   -   5        $??
LastNameCM??5/   /   .@?50   &   m? $??	Ascending??6/   m? 51   &   $??
Descending??6/   52   #   54      55      ?? 57      $??Employee No.??6&   $	
 100??6<   ?? 58      $??Salary??6%   5:      5<      &   System.Windows.Controls.DataGrid  5>   
   -   5        $
??grid??5>      $??4??6    5?      ?? 5@      .@?5A      m? -   5        $??Connect??5A      60   5B      5E      5F      5G      
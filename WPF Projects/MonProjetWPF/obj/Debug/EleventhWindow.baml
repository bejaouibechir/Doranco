   M S B A M L   `   `   `  ????G  CMonProjetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MonProjetWPFMonProjetWPF  5   	   7 clr-namespace:MonProjetWPF.ModelMonProjetWPF.Model  5   	   !    MonProjetWPF.EleventhWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MonProjetWPF     5   	   2model clr-namespace:MonProjetWPF.Model     5   	     ? Title$  EleventhWindow??5	   	   $	??450??6    $	??800??6-    ? 	Resources 5
       ?? Color 
  color1 
 color2"   MonProjetWPF.Model.Personnes  	personnes"   MonProjetWPF.Model.Employees  	employees??%?   &	        &	 %     &	 N     &	 a     ?? 5   
   $ Bisque??6   6)   ?? 5   
   $ 
LightGreen??6   6-     5   
   6     5   
   6   5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   .+?5   
   ?? -   5        $??employeeList??5      $??10q?6   #???  5      ?? 5   
   -   5        $??1??5       
 color3#??[ 5        sunriseBrush#??[ 5      $??Center=?5      $??Center=?5      $??Ajouter un element??5       ?? 5!   
   $??2??6    ?? View 5#      ?? 5%       ?? AllowsColumnReorder .  ?? ColumnHeaderToolTip$ Employee Information??66   .P?5'      ?? $??Identifiant??6N    ?? Width$	 100??6c    ?? DisplayMemberBinding 6%   ?? 	 ?? Path$	 Id?6c   ?? 5)      $	 100??6P    6%   ?? $
	 Name?.??5*      ?? .??6/   Name
 ? ContextMenu
 5+      ?? 5,   "   -   5        $??
LastNameCM??5,   /   .@?5-   &   m? $??	Ascending??6/   m? 5.   &   $??
Descending??6/   5/   #   51      52      ?? 54      $	??Age??6O   $	 100??6\    6%   ?? $		 Age?6\   55      58      5;      5`      
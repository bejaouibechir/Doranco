   M S B A M L   `   `   `  ????A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.ChessWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	     ? Title$  ChessWindow??5   	   $	??600??6   $	??900??6*   .??5	      ?  ? ContextMenu 5
   
   ?? 5      -   5        $??cm??5      .@?5      m? $??Pause??6   m? 5      $
??Stop??6   m? 5      $??Lance??6   m? 5      -   5        $??
Quitte ...??5      60   5       ? ColumnDefinitions 5   
   ?? 5      $??3* ?6   ?? 5      $??1* ?6   .+?5   
   ?  5      ?? 5      $??1* ?6#   ?? 5      $	??20* ?6#    ? RowDefinitions 5      ?? 5      $	??20* ?6    ?? 5      $??1* ?6    .+?5!      ? $??0,4,0,0q?6    5"      ?? 5#      $??1* ?6$   ?? 5$      $??1* ?6$   ?? 5%      $??1* ?6$   ?? 5&      $??1* ?6$   ?? 5'      $??1* ?6$   ?? 5(      $??1* ?6$   ?? 5)      $??1* ?6$   ?? 5*      $??1* ?6$   .+?5,      ?? $??1??6   $??7??6%   $??Center=?62   $??20(?5-      $??Center=?5.      ?? 5/      $??2??6   $??6??6%   $??Center=?62   $??20(?50      $??Center=?51      ?? 52      $??3??6   $??5??6%   $??Center=?62   $??20(?53      $??Center=?54      ?? 55      $??4??6   $??4??6%   $??Center=?62   $??20(?56      $??Center=?57      ?? 58      $??5??6   $??3??6%   $??Center=?62   $??20(?59      $??Center=?5:      ?? 5;      $??6??6   $??2??6%   $??Center=?62   $??20(?5<      $??Center=?5=      ?? 5>      $??7??6   $??1??6%   $??Center=?62   $??20(?5?      $??Center=?5@      ?? 5A      $??8??6   $??0??6%   $??Center=?62   $??20(?5B      $??Center=?5C      5D      ? 5G      $??1??6   $??1??6#   $??	11,0,11,0q?60    5H      ?? 5I      $??1* ?6'   ?? 5J      $??1* ?6'   ?? 5K      $??1* ?6'   ?? 5L      $??1* ?6'   ?? 5M      $??1* ?6'   ?? 5N      $??1* ?6'   ?? 5O      $??1* ?6'   ?? 5P      $??1* ?6'   .+?5R      ?? $??a??6   $??20(?6%   $??Center=?5S      $??Center=?67   ?? 5T      $??b??6   $??20(?6%   $??1??63   $??Center=?5U      $??Center=?67   ?? 5V      $??c??6   $??20(?6%   $??2??63   $??Center=?5W      $??Center=?67   ?? 5X      $??d??6   $??20(?6%   $??3??63   $??Center=?5Y      $??Center=?67   ?? 5Z      $??e??6   $??20(?6%   $??4??63   $??Center=?5[      $??Center=?67   ?? 5\      $??f??6   $??20(?6%   $??5??63   $??Center=?5]      $??Center=?67   ?? 5^      $??g??6   $??20(?6%   $??6??63   $??Center=?5_      $??Center=?67   ?? 5`      $??h??6   $??20(?6%   $??7??63   $??Center=?5a      $??Center=?67   5b      ?? 5e      $??10q?6   $??1??5f      
???   ?$??1q?5g   )    ?? CornerRadius$ 5??6=   ._?5h      ? -   5        $??scenegrd??5h   "   $??2q?6    5i      ?? 5j      $??1* ?6+   ?? 5k      $??1* ?6+   ?? 5l      $??1* ?6+   ?? 5m      $??1* ?6+   ?? 5n      $??1* ?6+   ?? 5o      $??1* ?6+   ?? 5p      $??1* ?6+   ?? 5q      $??1* ?6+    5s      ?? 5t      $??1* ?6(   ?? 5u      $??1* ?6(   ?? 5v      $??1* ?6(   ?? 5w      $??1* ?6(   ?? 5x      $??1* ?6(   ?? 5y      $??1* ?6(   ?? 5z      $??1* ?6(   ?? 5{      $??1* ?6(   .+?5      ?? 
???????$??0??65   ?? 5?      
???**??$??1??60   ?? 5?      
???????$??2??65   ?? 5?      
???**??$??3??60   ?? 5?      
???????$??4??65   ?? 5?      
???**??$??5??60   ?? 5?      
???????$??6??65   ?? 5?      
???**??$??7??60   ?? 5?      
???**??$??1??60   $??0??6=   ?? 5?      
???????$??1??66   $??1??6C   ?? 5?      
???**??$??1??60   $??2??6=   ?? 5?      
???????$??1??66   $??3??6C   ?? 5?      
???**??$??1??60   $??4??6=   ?? 5?      
???????$??1??66   $??5??6C   ?? 5?      
???**??$??1??60   $??6??6=   ?? 5?      
???????$??1??66   $??7??6C   ?? 5?      
???????$??2??65   $??0??6B   ?? 5?      
???**??$??2??60   $??1??6=   ?? 5?      
???????$??2??65   $??2??6B   ?? 5?      
???**??$??2??60   $??3??6=   ?? 5?      
???????$??2??65   $??4??6B   ?? 5?      
???**??$??2??60   $??5??6=   ?? 5?      
???????$??2??65   $??6??6B   ?? 5?      
???**??$??2??60   $??7??6=   ?? 5?      
???**??$??3??60   $??0??6=   ?? 5?      
???????$??3??66   $??1??6C   ?? 5?      
???**??$??3??60   $??2??6=   ?? 5?      
???????$??3??66   $??3??6C   ?? 5?      
???**??$??3??60   $??4??6=   ?? 5?      
???????$??3??66   $??5??6C   ?? 5?      
???**??$??3??60   $??6??6=   ?? 5?      
???????$??3??66   $??7??6C   ?? 5?      
???????$??4??65   $??0??6B   ?? 5?      
???**??$??4??60   $??1??6=   ?? 5?      
???????$??4??65   $??2??6B   ?? 5?      
???**??$??4??60   $??3??6=   ?? 5?      
???????$??4??65   $??4??6B   ?? 5?      
???**??$??4??60   $??5??6=   ?? 5?      
???????$??4??65   $??6??6B   ?? 5?      
???**??$??4??60   $??7??6=   ?? 5?      
???**??$??7??60   $??0??6=   ?? 5?      
???????$??7??66   $??1??6C   ?? 5?      
???**??$??7??60   $??2??6=   ?? 5?      
???????$??7??66   $??3??6C   ?? 5?      
???**??$??7??60   $??4??6=   ?? 5?      
???????$??7??66   $??5??6C   ?? 5?      
???**??$??7??60   $??6??6=   ?? 5?      
???????$??7??66   $??7??6C   ?? 5?      
???????$??6??65   $??0??6B   ?? 5?      
???**??$??6??60   $??1??6=   ?? 5?      
???????$??6??65   $??2??6B   ?? 5?      
???**??$??6??60   $??3??6=   ?? 5?      
???????$??6??65   $??4??6B   ?? 5?      
???**??$??6??60   $??5??6=   ?? 5?      
???????$??6??65   $??6??6B   ?? 5?      
???**??$??6??60   $??7??6=   ?? 5?      
???**??$??5??60   $??0??6=   ?? 5?      
???????$??5??66   $??1??6C   ?? 5?      
???**??$??5??60   $??2??6=   ?? 5?      
???????$??5??66   $??3??6C   ?? 5?      
???**??$??5??60   $??4??6=   ?? 5?      
???????$??5??66   $??5??6C   ?? 5?      
???**??$??5??60   $??6??6=   ?? 5?      
???????$??5??66   $??7??6C   5?      5?      5?      5?      5?      
   M S B A M L   `   `   `  ????@  <hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:hotel.Viewshotel.Views  5      %    hotel.Views.MakeReservationView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:hotel.Views     5      .??5	      ?   ? IsSharedSizeScope$
  True??6    ? RowDefinitions 5
   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??Make Reservation??6    
  Header#??[  6,   $??0??6L   ? 5   
   $??1??6   $??0 25 0 0q?6    5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    .+?5      ?? $??username??6   $??0??6(   ?? 5      $??1??6   $??0 5 0 0q?6b   ??6#   ?? *
Username+ ?? UpdateSourceTrigger$ PropertyChanged=?6b   5      ? 5   
   $??2??6   $??0 10 0 0q?6    5      ?? 5      $
??auto ?6    ?? 5       $
??auto ?6     ? ColumnDefinitions 5"      ?? 5#      $
??auto ?6#    z? SharedSizeGroup$ FirstColumn??60   ?? 5$      $
??auto ?6#   $ SecondColumn??60   .+?5'      ?? $??Floor No??6   $??0??6(   $??0??65   ?? 5(      $??1??6   $??0 5 0 0q?6e   $??0??6v   ??6#   ?? *FloorNumber+$ PropertyChanged=?6v   ?? 5*      $??10 0 0 0q?6   $??Room No??6*   $??0??69   $??1??6F   ?? 5+      $??1??6   $??10 5 0 0q?6d   $??1??6v   ??6#   ?? *
RoomNumber+$ PropertyChanged=?6v   5-      ? 5/   
   $??3??6   $??0 10 0 0q?6    50      ?? 51      $
??auto ?6    ?? 52      $
??auto ?6     54      ?? 55      $
??auto ?6#   $ FirstColumn??60   ?? 56      $
??auto ?6#   $ SecondColumn??60   .+?59      ?? $??
Start Date??6   $??0??6*   $??0??67   (  "System.Windows.Controls.DatePicker  5:      $??1??6   $??0 5 0 0q?6&   $??0??67      SelectedDate 6G   ?? *	StartTime+$ PropertyChanged=??? 5<      $??5 0 0 0q?6   $??End Date??6)   $??0??69   $??1??6F     5=      $??1??6   $??10 5 0 0q?6&   $??1??68    6H   ?? *	EndTime+$ PropertyChanged=?5?      ?? 5A   
    ?? Orientation$ 
Horizontal=?6   $??4??6.   $??0 10 0 0q?6;   .+?5B      ?? $??Submit??6   ??6&   ?? *SubmitCommand+?? 5C      $??Cancel??6   $??10 0 0 0q?6&   ??68   ?? *CancelCommand+5D      5F      5G      
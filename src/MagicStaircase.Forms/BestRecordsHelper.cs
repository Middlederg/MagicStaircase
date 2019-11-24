using MagicStaircase.Core;
using System;
using System.Windows.Forms;

namespace MagicStaircase.Forms
{
    public static class BestRecordsHelper
    {
        public static void FillWith(this ListView lvw, int position, Player player, Score score, Time time, DateTime date)
        {
            ListViewItem item = new ListViewItem($"{position}. ");
            item.SubItems.Add(player.ToString());
            item.SubItems.Add(score.ToString());
            item.SubItems.Add(date.ToShortDateString());
            item.SubItems.Add(time.ToString());
            lvw.Items.Add(item);
        }
    }
}

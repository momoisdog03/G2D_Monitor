﻿using G2D_Monitor.Manager;
using System.Reflection;

namespace G2D_Monitor.Plugins
{
    internal class PlayerPlugin : Plugin
    {
        private readonly ListView MainListView = NewListView();

        protected override string Name => "Players";

        protected override void DoUpdate(Context? context)
        {
            if (context == null)
            {
                foreach (ListViewItem item in MainListView.Items) item.SubItems[1].Text = string.Empty;
            }
            else
            {
                foreach (ListViewItem item in MainListView.Items)
                {
                    if (item.Tag is KeyValuePair<int, PropertyInfo> pair)
                    {
                        var text = pair.Value.GetValue(context.Players[pair.Key])?.ToString() ?? string.Empty;
                        if (!item.SubItems[1].Text.Equals(text)) item.SubItems[1].Text = text;
                    }
                }
            }
        }

        protected override void Initialize(TabPage tab)
        {
            tab.Controls.Add(MainListView);
            var props = typeof(Player).GetProperties().ToList();
            props.Sort((a, b) => a.Name.CompareTo(b.Name));
            for (var i = 0; i < Context.PLAYER_NUM; i++)
            {
                var group = new ListViewGroup("Player " + (i + 1));
                MainListView.Groups.Add(group);
                foreach (var prop in props)
                {
                    var item = MainListView.Items.Add(prop.Name);
                    item.Group = group;
                    item.Tag = new KeyValuePair<int, PropertyInfo>(i, prop);
                    item.SubItems.Add(string.Empty);
                }
            }
        }
    }
}
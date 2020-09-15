using Microsoft.AspNetCore.Components;

namespace AntDesign
{
    public partial class ListItemMeta : AntDomComponentBase
    {
        public string PrefixName { get; set; } = "ant-list-item-meta";

        [Parameter] public RenderFragment Title { get; set; }

        [Parameter] public OneOf.OneOf<string, RenderFragment> Avatar { get; set; }

        [Parameter] public string Description { get; set; }

        [CascadingParameter] public ListItem ListItem { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SetClassMap();
        }

        protected void SetClassMap()
        {
            ClassMapper.Clear()
                .Add(PrefixName);
        }
    }
}

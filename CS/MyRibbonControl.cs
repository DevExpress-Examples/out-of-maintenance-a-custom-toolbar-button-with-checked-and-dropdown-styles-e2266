using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;


namespace CustomCheckAndDropDownButton {
    public class MyRibbonControl : RibbonControl {
        protected override RibbonBarManager CreateBarManager() {
            return new MyRibbonBarManager(this);
        }
    }

    public class MyRibbonBarManager : RibbonBarManager {
        public MyRibbonBarManager(RibbonControl ribbon) : base(ribbon) { }
        protected override RibbonItemViewInfo CreateItemViewInfo(BaseRibbonViewInfo viewInfo, IRibbonItem item) {
            BarButtonItemLink link = item as BarButtonItemLink;
            if(link != null && link.Item is BarCheckAndDropDownButton) 
                return new RibbonCheckAndDropDownButtonLinkViewInfo(viewInfo, item);
            return base.CreateItemViewInfo(viewInfo, item);
        }
    }

    public class RibbonCheckAndDropDownButtonLinkViewInfo : RibbonSplitButtonItemViewInfo {
        public RibbonCheckAndDropDownButtonLinkViewInfo(BaseRibbonViewInfo viewInfo, IRibbonItem item) : base(viewInfo, item) { }

        protected override int CalcImageIndex(ObjectState state) {
            int res = 0;
            if(state == ObjectState.Hot) res = 1;
            if((state & ObjectState.Pressed) != 0) res = 2;
            if(Item.IsChecked) res += 3;
            return res;
        }

        public override SkinElementInfo GetItemInfo() {
            SkinElementInfo info = new SkinElementInfo(RibbonSkins.GetSkin(ViewInfo.Provider)[RibbonSkins.SkinLargeButton]);
            info.Bounds = PushButtonBounds;
            info.State = CalcState();
            info.ImageIndex = CalcImageIndex(info.State);
            return info;
        }
    }
}

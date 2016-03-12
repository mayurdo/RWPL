using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software;
using RWPLEntityModel;

namespace Base.Software.Helper
{
    public class EntryForm<TEntity> : BaseEntryForm<TEntity> where TEntity : IEntity, new()
    {
        public EntryForm(Control form, long srNo = 0)
            : base(form, srNo)
        {
            HasGridForm = false;

            if (_entity.SrNo != 0)
                BindControlsWithEntityModel(_bindControls, _entity);
        }

        protected override void BindAditionalEvent(Control control, string[] accDescriptionList)
        {
            
        }
    }
}

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorModal
{
    public class ModalService
    {
        public event Action OnShow;
        public event Action OnClose;

        public void Show()
        {   
            OnShow?.Invoke();
        }

        public void Hide()
        {
            OnClose?.Invoke();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DetectKeyboard.Win32Wrap;
using System.Runtime.InteropServices;

namespace DetectKeyboard.MessageFilters
{
    class RawInputFiltering : IMessageFilter
    {
        public bool Initializing { get; set; }

        private Form currentForm;
        private Dictionary<IntPtr, Control> controlByKeyboard;

        public RawInputFiltering(Form currentForm)
        {
            this.currentForm = currentForm;
            controlByKeyboard = new Dictionary<IntPtr, Control>();
        }

        public bool PreFilterMessage(ref Message m)
        {
            if ((WM)m.Msg == WM.INPUT)
            {

                var input = new RawInput();
                int outSize = 0;
                int size = Marshal.SizeOf(typeof(RawInput));

                outSize = Win32MinimalWrap.GetRawInputData( m.LParam, 
                                                            RawInputCommand.Input, 
                                                            out input, 
                                                            ref size, 
                                                            Marshal.SizeOf(typeof(RawInputHeader)));
                input = ProcessRawInput(input, outSize);

                Win32MinimalWrap.DispatchMessage(ref m);
                return false;
            }

            return false;
        }

        private RawInput ProcessRawInput(RawInput input, int outSize)
        {
            if (outSize != -1)
            {
                if (input.Header.Type == RawInputType.Keyboard)
                {
                    if (Initializing)
                    {
                        var currentControl = currentForm.ActiveControl;
                        controlByKeyboard[input.Header.Device] = currentControl;

                        var initializationMessage = String.Format("{0} <- Keyboard[{1}]", currentControl.Name, input.Header.Device);
                        MessageBox.Show(initializationMessage);
                    }
                    else
                    {
                        var msg = String.Format("[{0}] {1}", input.Header.Device, input.Data.Keyboard.VirtualKey.ToString());

                        if (controlByKeyboard.ContainsKey(input.Header.Device))
                        {
                            Win32MinimalWrap.SendMessage(   controlByKeyboard[input.Header.Device].Handle, 
                                                            (uint)WM.KEYDOWN, 
                                                            (IntPtr)input.Data.Keyboard.VirtualKey, 
                                                            IntPtr.Zero);
                        }
                        else
                        {
                            MessageBox.Show(msg);
                        }
                    }
                }
            }
            return input;
        }
    }
}

using System;
using System.Windows.Forms;

namespace Win32.WGL
{
	/// <summary>
	/// Event arguments for unhandled WndProc messages.
	/// </summary>
	public class OpenGLMessageEventArgs : EventArgs
	{
		/// <summary>
		/// The message.
		/// </summary>
		public Message Message;

		/// <summary>
		/// Construct an instance of <see cref="OpenGLMessageEventArgs"/>.
		/// </summary>
		/// <param name="message">A <see cref="Message"/>.</param>
		public OpenGLMessageEventArgs(Message message) { Message=message; }
	}
}

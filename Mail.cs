using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to using the in game mailbox. 
    /// Make sure you check <see cref="IsOpen"/> before attempting to use anything in this class.
    /// </summary>
    public class Mail : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mail"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Mail(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Mail"/> class.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        public Mail(string Arg) : base(LavishScript.Objects.GetObject("Mail", Arg)) {}

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Mail"/> is open.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Mail"/> is open; otherwise, <c>false</c>.
        /// </value>
        public bool IsOpen { get { return IsValid; } }

        /// <summary>
        /// Gets the num messages of this <see cref="Mail"/>.
        /// </summary>
        /// <value>The num messages.</value>
        public int NumMessages { get { return GetMember<int>("NumMessages"); } }

        /// <summary>
        /// Gets a value indicating whether [have unread mail].
        /// </summary>
        /// <value><c>true</c> if [have unread mail]; otherwise, <c>false</c>.</value>
        public bool HaveUnreadMail { get { return GetMember<bool>("HaveUnreadMail"); } }

        /// <summary>
        /// Same as <see cref="NumMessages"/>.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use MessageCount instead.")]
        public int Message()
        {
            return GetMember<int>("NumMessages");
        }

        /// <summary>
        /// Gets the <see cref="MailMessage"/> at the specified index.
        /// </summary>
        /// <param name="Index">The index. (1 - <see cref="NumMessages"/>)</param>
        /// <returns></returns>
        public MailMessage Message(int Index)
        {
            LavishScriptObject Obj = GetMember("Message", Index.ToString());
            return new MailMessage(Obj);
        }

        /// <summary>
        /// Sets the COD.
        /// </summary>
        /// <returns></returns>
        public bool SetCOD()
        {
            return ExecuteMethod("SetCOD");
        }

        /// <summary>
        /// Unsets the COD.
        /// </summary>
        /// <returns></returns>
        public bool UnsetCOD()
        {
            return ExecuteMethod("UnsetCOD");
        }

        /// <summary>
        /// Sends this <see cref="Mail"/>.
        /// </summary>
        /// <returns></returns>
        public bool Send()
        {
            return ExecuteMethod("Send");
        }

        /// <summary>
        /// Cancels this <see cref="Mail"/>.
        /// </summary>
        /// <returns></returns>
        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }
    }
}
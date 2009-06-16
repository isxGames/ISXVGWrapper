using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to a mail message. 
    /// </summary>
    public class MailMessage : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailMessage"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public MailMessage(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="MailMessage"/> class.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        public MailMessage(string Arg) : base(LavishScript.Objects.GetObject("MailMessage", Arg)) {}

        /// <summary>
        /// Gets from of this <see cref="MailMessage"/>.
        /// </summary>
        /// <value>From.</value>
        public string From { get { return GetMember<string>("From"); } }

        /// <summary>
        /// Gets the subject of this <see cref="MailMessage"/>.
        /// </summary>
        /// <value>The subject.</value>
        public string Subject { get { return GetMember<string>("Subject"); } }

        /// <summary>
        /// Gets the body of this <see cref="MailMessage"/>.
        /// </summary>
        /// <value>The body.</value>
        public string Body { get { return GetMember<string>("Body"); } }

        /// <summary>
        /// Gets the attached item of this <see cref="MailMessage"/>.
        /// </summary>
        /// <value>The attached item.</value>
        public Item AttachedItem { get { return GetMember<Item>("AttachedItem"); } }

        /// <summary>
        /// Gets the shipping fee of this <see cref="MailMessage"/>.
        /// </summary>
        /// <value>The shipping fee.</value>
        public int ShippingFee { get { return GetMember<int>("ShippingFee"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="MailMessage"/> is unread.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="MailMessage"/> is unread; otherwise, <c>false</c>.
        /// </value>
        public bool IsUnread { get { return GetMember<bool>("IsUnread"); } }

        /// <summary>
        /// Reads this <see cref="MailMessage"/>.
        /// </summary>
        /// <returns></returns>
        public bool Read()
        {
            return ExecuteMethod("Read");
        }

        /// <summary>
        /// Replies this <see cref="MailMessage"/>.
        /// </summary>
        /// <returns></returns>
        public bool Reply()
        {
            return ExecuteMethod("Reply");
        }

        /// <summary>
        /// Returns this <see cref="MailMessage"/>.
        /// </summary>
        /// <returns></returns>
        public bool Return()
        {
            return ExecuteMethod("Return");
        }

        /// <summary>
        /// Deletes this <see cref="MailMessage"/>.
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return ExecuteMethod("Delete");
        }

        /// <summary>
        /// Takes the item.
        /// </summary>
        /// <returns></returns>
        public bool TakeItem()
        {
            return ExecuteMethod("TakeItem");
        }

        /// <summary>
        /// Takes the coin.
        /// </summary>
        /// <returns></returns>
        public bool TakeCoin()
        {
            return ExecuteMethod("TakeCoin");
        }
    }
}
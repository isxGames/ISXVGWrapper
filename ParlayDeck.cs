using System;
using System.Collections;
using System.Collections.Generic;
using LavishScriptAPI;
using LavishVMAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// <para>This is a simple class that holds your current ParlayCard deck.</para>
    /// <para>It is enumerable.</para>
    /// <para> Note: Each frame's instance of GetEnumerator is valid for only that frame. (Same lifetime as ParlayCard)</para> 
    /// </summary>
    public class ParlayDeck : IEnumerable<ParlayCard>
    {
        /// <summary>
        /// Gets the number of ParlayCards in this <see cref="ParlayDeck"/>.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get
            {
                using (new FrameLock(true))
                {
                    return LavishScript.Objects.GetObject<int>("ParlayCard");
                }
            }
        }

        /// <summary>
        /// Gets the <see cref="Vanguard.ISXVG.ParlayCard"/> at the specified index.
        /// </summary>
        /// <value></value>
        public ParlayCard this[int index] { get { return new ParlayCard(LavishScript.Objects.GetObject("ParlayCard", index.ToString())); } }

        /// <summary>
        /// Gets the <see cref="Vanguard.ISXVG.ParlayCard"/> with the specified name.
        /// </summary>
        /// <value></value>
        public ParlayCard this[string name] { get { return new ParlayCard(LavishScript.Objects.GetObject("ParlayCard", name)); } }

        #region IEnumerable<ParlayCard> Members

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public IEnumerator<ParlayCard> GetEnumerator()
        {
            return new ParlayEnumerator(this);
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        /// <summary>
        /// Creates a instance of the <see cref="ParlayDeck"/> class.
        /// </summary>
        /// <returns></returns>
        public static ParlayDeck Create()
        {
            return new ParlayDeck();
        }

        #region Nested type: ParlayEnumerator

        private class ParlayEnumerator : IEnumerator<ParlayCard>
        {
            private List<ParlayCard> _cards = new List<ParlayCard>();
            private int _currentIndex = -1;

            /// <summary>
            /// Initializes a new instance of the <see cref="ParlayEnumerator"/> class.
            /// </summary>
            /// <param name="deck">The deck.</param>
            public ParlayEnumerator(ParlayDeck deck)
            {
                ParlayDeck tmp = deck;
                int count = tmp.Count;
                for (int i = 0; i < count; i++)
                {
                    _cards.Add(tmp[i]);
                }
            }

            #region IEnumerator<ParlayCard> Members

            /// <summary>
            /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
            /// </summary>
            /// <filterpriority>2</filterpriority>
            public void Dispose()
            {
                _cards = null;
                _currentIndex = -1;
                GC.SuppressFinalize(this);
            }

            /// <summary>
            /// Advances the enumerator to the next element of the collection.
            /// </summary>
            /// <returns>
            /// true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.
            /// </returns>
            /// <exception cref="T:System.InvalidOperationException">
            /// The collection was modified after the enumerator was created. 
            /// </exception><filterpriority>2</filterpriority>
            public bool MoveNext()
            {
                if (_currentIndex < _cards.Count)
                {
                    _currentIndex++;
                }
                return _currentIndex != _cards.Count;
            }

            /// <summary>
            /// Sets the enumerator to its initial position, which is before the first element in the collection.
            /// </summary>
            /// <exception cref="T:System.InvalidOperationException">
            /// The collection was modified after the enumerator was created. 
            /// </exception><filterpriority>2</filterpriority>
            public void Reset()
            {
                _currentIndex = -1;
            }

            /// <summary>
            /// Gets the element in the collection at the current position of the enumerator.
            /// </summary>
            /// <returns>
            /// The element in the collection at the current position of the enumerator.
            /// </returns>
            public ParlayCard Current { get { return _cards[_currentIndex]; } }

            /// <summary>
            /// Gets the current element in the collection.
            /// </summary>
            /// <returns>
            /// The current element in the collection.
            /// </returns>
            /// <exception cref="T:System.InvalidOperationException">
            /// The enumerator is positioned before the first element of the collection or after the last element.
            /// </exception><filterpriority>2</filterpriority>
            object IEnumerator.Current { get { return Current; } }

            #endregion
        }

        #endregion
    }
}

/* =====
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
===== */

namespace Zephyr.Utils.NPOI.DDF
{
    using System;
    using System.IO;
    using System.Collections;
    using Zephyr.Utils.NPOI.Util;
    using System.Collections.Generic;

    /// <summary>
    /// The base abstract record from which all escher records are defined.  Subclasses will need
    /// to define methods for serialization/deserialization and for determining the record size.
    /// @author Glen Stampoultzis
    /// </summary>
    abstract public class EscherRecord : ICloneable
    {
        private short options;
        private short recordId;

        /// <summary>
        /// Initializes a new instance of the <see cref="EscherRecord"/> class.
        /// </summary>
        public EscherRecord()
        {
        }

        /// <summary>
        /// Delegates to FillFields(byte[], int, EscherRecordFactory)
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="f">The f.</param>
        /// <returns></returns>
        public int FillFields(byte[] data, EscherRecordFactory f)
        {
            return FillFields(data, 0, f);
        }

        /// <summary>
        /// The contract of this method is to deSerialize an escher record including
        /// it's children.
        /// </summary>
        /// <param name="data">The byte array containing the Serialized escher
        /// records.</param>
        /// <param name="offset">The offset into the byte array.</param>
        /// <param name="recordFactory">A factory for creating new escher records.</param>
        /// <returns>The number of bytes written.</returns>       
        public abstract int FillFields(byte[] data, int offset, EscherRecordFactory recordFactory);

        /// <summary>
        /// Reads the 8 byte header information and populates the 
        /// <c>options</c>
        /// and 
        /// <c>recordId</c>
        ///  records.
        /// </summary>
        /// <param name="data">the byte array to Read from</param>
        /// <param name="offset">the offset to start Reading from</param>
        /// <returns>the number of bytes remaining in this record.  This</returns>
        protected int ReadHeader(byte[] data, int offset)
        {
            EscherRecordHeader header = EscherRecordHeader.ReadHeader(data, offset);
            options = header.Options;
            recordId = header.RecordId;
            return header.RemainingBytes;
        }

        /// <summary>
        /// Determine whether this is a container record by inspecting the option
        /// field.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is container record; otherwise, <c>false</c>.
        /// </value>
        public bool IsContainerRecord
        {
            get { return (options & (short)0x000f) == (short)0x000f; }
        }

        /// <summary>
        /// Gets or sets the options field for this record.  All records have one
        /// </summary>
        /// <value>The options.</value>
        public virtual short Options
        {
            get { return options; }
            set { this.options = value; }
        }

        /// <summary>
        /// Serializes to a new byte array.  This is done by delegating to
        /// Serialize(int, byte[]);
        /// </summary>
        /// <returns>the Serialized record.</returns>
        public byte[] Serialize()
        {
            byte[] retval = new byte[RecordSize];

            int length=Serialize(0, retval);
            return retval;
        }
        /// <summary>
        /// Serializes to an existing byte array without serialization listener.
        /// This is done by delegating to Serialize(int, byte[], EscherSerializationListener).
        /// </summary>
        /// <param name="offset">the offset within the data byte array.</param>
        /// <param name="data">the data array to Serialize to.</param>
        /// <returns>The number of bytes written.</returns>
        public int Serialize(int offset, byte[] data)
        {
            return Serialize(offset, data, new NullEscherSerializationListener());
        }

        /// <summary>
        /// Serializes the record to an existing byte array.
        /// </summary>
        /// <param name="offset">the offset within the byte array.</param>
        /// <param name="data">the offset within the byte array</param>
        /// <param name="listener">a listener for begin and end serialization events.  This.
        /// is useful because the serialization is
        /// hierarchical/recursive and sometimes you need to be able
        /// break into that.
        /// </param>
        /// <returns></returns>
        public abstract int Serialize(int offset, byte[] data, EscherSerializationListener listener);


        /// <summary>
        /// Subclasses should effeciently return the number of bytes required to
        /// Serialize the record.
        /// </summary>
        /// <value>number of bytes</value>
        abstract public int RecordSize { get; }

        /// <summary>
        /// Return the current record id.
        /// </summary>
        /// <value>The 16 bit record id.</value>
        public virtual short RecordId
        {
            get { return recordId; }
            set { this.recordId = value; }
        }


        /// <summary>
        /// Gets or sets the child records.
        /// </summary>
        /// <value>Returns the children of this record.  By default this will
        /// be an empty list.  EscherCotainerRecord is the only record that may contain children.</value>
        public virtual List<EscherRecord> ChildRecords
        {
            get { return new List<EscherRecord>(); }
            set { throw new ArgumentException("This record does not support child records."); }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public object Clone()
        {
            throw new Exception("The class " + this.GetType().Name + " needs to define a clone method");
        }

        /// <summary>
        /// Returns the indexed child record.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public EscherRecord GetChild(int index)
        {
            return (EscherRecord)ChildRecords[index];
        }

        /// <summary>
        /// The display methods allows escher variables to print the record names
        /// according to their hierarchy.
        /// </summary>
        /// <param name="indent">The current indent level.</param>  
        public virtual void Display(int indent)
        {
            for (int i = 0; i < indent * 4; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine(RecordName);
        }

        /// <summary>
        /// Gets the name of the record.
        /// </summary>
        /// <value>The name of the record.</value>
        public abstract String RecordName { get; }

        /// <summary>
        /// Returns the instance part of the option record.
        /// </summary>
        /// <returns>The instance part of the record</returns>
        public short GetInstance()
        {
            return (short)(options >> 4);
        }

        /// <summary>
        /// This class Reads the standard escher header.
        /// </summary>
        internal class EscherRecordHeader
        {
            private short options;
            private short recordId;
            private int remainingBytes;

            private EscherRecordHeader()
            {
            }

            /// <summary>
            /// Reads the header.
            /// </summary>
            /// <param name="data">The data.</param>
            /// <param name="offset">The off set.</param>
            /// <returns></returns>
            public static EscherRecordHeader ReadHeader(byte[] data, int offset)
            {
                EscherRecordHeader header = new EscherRecordHeader();
                header.options = LittleEndian.GetShort(data, offset);
                header.recordId = LittleEndian.GetShort(data, offset + 2);
                header.remainingBytes = LittleEndian.GetInt(data, offset + 4);
                return header;
            }


            /// <summary>
            /// Gets the options.
            /// </summary>
            /// <value>The options.</value>
            public short Options
            {
                get { return options; }
            }

            /// <summary>
            /// Gets the record id.
            /// </summary>
            /// <value>The record id.</value>
            public virtual short RecordId
            {
                get { return recordId; }
            }

            /// <summary>
            /// Gets the remaining bytes.
            /// </summary>
            /// <value>The remaining bytes.</value>
            public int RemainingBytes
            {
                get { return remainingBytes; }
            }

            /// <summary>
            /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
            /// </returns>
            public override String ToString()
            {
                return "EscherRecordHeader{" +
                        "options=" + options +
                        ", recordId=" + recordId +
                        ", remainingBytes=" + remainingBytes +
                        "}";
            }
        }
    }
}
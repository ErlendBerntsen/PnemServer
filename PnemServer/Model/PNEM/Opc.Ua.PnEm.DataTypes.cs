/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.DI;

namespace Opc.Ua.PnEm
{
    #region AccuracyClassEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_AccuracyClassEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public enum AccuracyClassEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_0_0")]
        ACCURACY_CLASS_0 = 0,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_1_1")]
        ACCURACY_CLASS_1 = 1,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_2_2")]
        ACCURACY_CLASS_2 = 2,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_3_3")]
        ACCURACY_CLASS_3 = 3,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_4_4")]
        ACCURACY_CLASS_4 = 4,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_5_5")]
        ACCURACY_CLASS_5 = 5,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_6_6")]
        ACCURACY_CLASS_6 = 6,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_7_7")]
        ACCURACY_CLASS_7 = 7,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_8_8")]
        ACCURACY_CLASS_8 = 8,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_9_9")]
        ACCURACY_CLASS_9 = 9,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_10_10")]
        ACCURACY_CLASS_10 = 10,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_11_11")]
        ACCURACY_CLASS_11 = 11,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_12_12")]
        ACCURACY_CLASS_12 = 12,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_13_13")]
        ACCURACY_CLASS_13 = 13,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_14_14")]
        ACCURACY_CLASS_14 = 14,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_CLASS_15_15")]
        ACCURACY_CLASS_15 = 15,
    }

    #region AccuracyClassEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAccuracyClassEnumeration", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "AccuracyClassEnumeration")]
    public partial class AccuracyClassEnumerationCollection : List<AccuracyClassEnumeration>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public AccuracyClassEnumerationCollection() {}

        /// <remarks />
        public AccuracyClassEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AccuracyClassEnumerationCollection(IEnumerable<AccuracyClassEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AccuracyClassEnumerationCollection(AccuracyClassEnumeration[] values)
        {
            if (values != null)
            {
                return new AccuracyClassEnumerationCollection(values);
            }

            return new AccuracyClassEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator AccuracyClassEnumeration[](AccuracyClassEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AccuracyClassEnumerationCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AccuracyClassEnumerationCollection clone = new AccuracyClassEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AccuracyClassEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AccuracyDomainEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_AccuracyDomainEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public enum AccuracyDomainEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "ACCURACY_DOMAIN_RESERVED_0")]
        ACCURACY_DOMAIN_RESERVED = 0,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_DOMAIN_PERCENT_FULL_SCALE_1")]
        ACCURACY_DOMAIN_PERCENT_FULL_SCALE = 1,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_DOMAIN_PERCENT_ACTUAL_READING_2")]
        ACCURACY_DOMAIN_PERCENT_ACTUAL_READING = 2,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_DOMAIN_IEC_3")]
        ACCURACY_DOMAIN_IEC = 3,

        /// <remarks />
        [EnumMember(Value = "ACCURACY_DOMAIN_EN_4")]
        ACCURACY_DOMAIN_EN = 4,
    }

    #region AccuracyDomainEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAccuracyDomainEnumeration", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "AccuracyDomainEnumeration")]
    public partial class AccuracyDomainEnumerationCollection : List<AccuracyDomainEnumeration>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public AccuracyDomainEnumerationCollection() {}

        /// <remarks />
        public AccuracyDomainEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AccuracyDomainEnumerationCollection(IEnumerable<AccuracyDomainEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AccuracyDomainEnumerationCollection(AccuracyDomainEnumeration[] values)
        {
            if (values != null)
            {
                return new AccuracyDomainEnumerationCollection(values);
            }

            return new AccuracyDomainEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator AccuracyDomainEnumeration[](AccuracyDomainEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AccuracyDomainEnumerationCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AccuracyDomainEnumerationCollection clone = new AccuracyDomainEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AccuracyDomainEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PeClassEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_PeClassEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public enum PeClassEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "PE_CLASS1_0")]
        PE_CLASS1 = 0,

        /// <remarks />
        [EnumMember(Value = "PE_CLASS2_1")]
        PE_CLASS2 = 1,

        /// <remarks />
        [EnumMember(Value = "PE_CLASS3_2")]
        PE_CLASS3 = 2,
    }

    #region PeClassEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPeClassEnumeration", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "PeClassEnumeration")]
    public partial class PeClassEnumerationCollection : List<PeClassEnumeration>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public PeClassEnumerationCollection() {}

        /// <remarks />
        public PeClassEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PeClassEnumerationCollection(IEnumerable<PeClassEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PeClassEnumerationCollection(PeClassEnumeration[] values)
        {
            if (values != null)
            {
                return new PeClassEnumerationCollection(values);
            }

            return new PeClassEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator PeClassEnumeration[](PeClassEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PeClassEnumerationCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PeClassEnumerationCollection clone = new PeClassEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PeClassEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PeSubclassEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_PeSubclassEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public enum PeSubclassEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "PE_SUBCLASS1_0")]
        PE_SUBCLASS1 = 0,

        /// <remarks />
        [EnumMember(Value = "PE_SUBCLASS2_1")]
        PE_SUBCLASS2 = 1,
    }

    #region PeSubclassEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPeSubclassEnumeration", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "PeSubclassEnumeration")]
    public partial class PeSubclassEnumerationCollection : List<PeSubclassEnumeration>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public PeSubclassEnumerationCollection() {}

        /// <remarks />
        public PeSubclassEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PeSubclassEnumerationCollection(IEnumerable<PeSubclassEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PeSubclassEnumerationCollection(PeSubclassEnumeration[] values)
        {
            if (values != null)
            {
                return new PeSubclassEnumerationCollection(values);
            }

            return new PeSubclassEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator PeSubclassEnumeration[](PeSubclassEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PeSubclassEnumerationCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PeSubclassEnumerationCollection clone = new PeSubclassEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PeSubclassEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AcPeDataType Class
    #if (!OPCUA_EXCLUDE_AcPeDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public partial class AcPeDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public AcPeDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_a = (float)0;
            m_b = (float)0;
            m_c = (float)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "A", IsRequired = false, Order = 1)]
        public float A
        {
            get { return m_a;  }
            set { m_a = value; }
        }

        /// <remarks />
        [DataMember(Name = "B", IsRequired = false, Order = 2)]
        public float B
        {
            get { return m_b;  }
            set { m_b = value; }
        }

        /// <remarks />
        [DataMember(Name = "C", IsRequired = false, Order = 3)]
        public float C
        {
            get { return m_c;  }
            set { m_c = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.AcPeDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.AcPeDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.AcPeDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.AcPeDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            encoder.WriteFloat("A", A);
            encoder.WriteFloat("B", B);
            encoder.WriteFloat("C", C);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            A = decoder.ReadFloat("A");
            B = decoder.ReadFloat("B");
            C = decoder.ReadFloat("C");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AcPeDataType value = encodeable as AcPeDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_a, value.m_a)) return false;
            if (!Utils.IsEqual(m_b, value.m_b)) return false;
            if (!Utils.IsEqual(m_c, value.m_c)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AcPeDataType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AcPeDataType clone = (AcPeDataType)base.MemberwiseClone();

            clone.m_a = (float)Utils.Clone(this.m_a);
            clone.m_b = (float)Utils.Clone(this.m_b);
            clone.m_c = (float)Utils.Clone(this.m_c);

            return clone;
        }
        #endregion

        #region Private Fields
        private float m_a;
        private float m_b;
        private float m_c;
        #endregion
    }

    #region AcPeDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAcPeDataType", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "AcPeDataType")]
    public partial class AcPeDataTypeCollection : List<AcPeDataType>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public AcPeDataTypeCollection() {}

        /// <remarks />
        public AcPeDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AcPeDataTypeCollection(IEnumerable<AcPeDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AcPeDataTypeCollection(AcPeDataType[] values)
        {
            if (values != null)
            {
                return new AcPeDataTypeCollection(values);
            }

            return new AcPeDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator AcPeDataType[](AcPeDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AcPeDataTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AcPeDataTypeCollection clone = new AcPeDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AcPeDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AcPpDataType Class
    #if (!OPCUA_EXCLUDE_AcPpDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public partial class AcPpDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public AcPpDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_a_b = (float)0;
            m_b_c = (float)0;
            m_c_a = (float)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "A_b", IsRequired = false, Order = 1)]
        public float A_b
        {
            get { return m_a_b;  }
            set { m_a_b = value; }
        }

        /// <remarks />
        [DataMember(Name = "B_c", IsRequired = false, Order = 2)]
        public float B_c
        {
            get { return m_b_c;  }
            set { m_b_c = value; }
        }

        /// <remarks />
        [DataMember(Name = "C_a", IsRequired = false, Order = 3)]
        public float C_a
        {
            get { return m_c_a;  }
            set { m_c_a = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.AcPpDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.AcPpDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.AcPpDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.AcPpDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            encoder.WriteFloat("A_b", A_b);
            encoder.WriteFloat("B_c", B_c);
            encoder.WriteFloat("C_a", C_a);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            A_b = decoder.ReadFloat("A_b");
            B_c = decoder.ReadFloat("B_c");
            C_a = decoder.ReadFloat("C_a");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AcPpDataType value = encodeable as AcPpDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_a_b, value.m_a_b)) return false;
            if (!Utils.IsEqual(m_b_c, value.m_b_c)) return false;
            if (!Utils.IsEqual(m_c_a, value.m_c_a)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AcPpDataType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AcPpDataType clone = (AcPpDataType)base.MemberwiseClone();

            clone.m_a_b = (float)Utils.Clone(this.m_a_b);
            clone.m_b_c = (float)Utils.Clone(this.m_b_c);
            clone.m_c_a = (float)Utils.Clone(this.m_c_a);

            return clone;
        }
        #endregion

        #region Private Fields
        private float m_a_b;
        private float m_b_c;
        private float m_c_a;
        #endregion
    }

    #region AcPpDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAcPpDataType", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "AcPpDataType")]
    public partial class AcPpDataTypeCollection : List<AcPpDataType>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public AcPpDataTypeCollection() {}

        /// <remarks />
        public AcPpDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AcPpDataTypeCollection(IEnumerable<AcPpDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AcPpDataTypeCollection(AcPpDataType[] values)
        {
            if (values != null)
            {
                return new AcPpDataTypeCollection(values);
            }

            return new AcPpDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator AcPpDataType[](AcPpDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AcPpDataTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AcPpDataTypeCollection clone = new AcPpDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AcPpDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region EnergyStateInformationDataType Class
    #if (!OPCUA_EXCLUDE_EnergyStateInformationDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public partial class EnergyStateInformationDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public EnergyStateInformationDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_iDSource = (byte)0;
            m_iDDestination = (byte)0;
            m_regularTimeToOperate = (double)0;
            m_modePowerConsumption = (float)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "IDSource", IsRequired = false, Order = 1)]
        public byte IDSource
        {
            get { return m_iDSource;  }
            set { m_iDSource = value; }
        }

        /// <remarks />
        [DataMember(Name = "IDDestination", IsRequired = false, Order = 2)]
        public byte IDDestination
        {
            get { return m_iDDestination;  }
            set { m_iDDestination = value; }
        }

        /// <remarks />
        [DataMember(Name = "RegularTimeToOperate", IsRequired = false, Order = 3)]
        public double RegularTimeToOperate
        {
            get { return m_regularTimeToOperate;  }
            set { m_regularTimeToOperate = value; }
        }

        /// <remarks />
        [DataMember(Name = "ModePowerConsumption", IsRequired = false, Order = 4)]
        public float ModePowerConsumption
        {
            get { return m_modePowerConsumption;  }
            set { m_modePowerConsumption = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.EnergyStateInformationDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.EnergyStateInformationDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.EnergyStateInformationDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.EnergyStateInformationDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            encoder.WriteByte("IDSource", IDSource);
            encoder.WriteByte("IDDestination", IDDestination);
            encoder.WriteDouble("RegularTimeToOperate", RegularTimeToOperate);
            encoder.WriteFloat("ModePowerConsumption", ModePowerConsumption);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            IDSource = decoder.ReadByte("IDSource");
            IDDestination = decoder.ReadByte("IDDestination");
            RegularTimeToOperate = decoder.ReadDouble("RegularTimeToOperate");
            ModePowerConsumption = decoder.ReadFloat("ModePowerConsumption");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            EnergyStateInformationDataType value = encodeable as EnergyStateInformationDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_iDSource, value.m_iDSource)) return false;
            if (!Utils.IsEqual(m_iDDestination, value.m_iDDestination)) return false;
            if (!Utils.IsEqual(m_regularTimeToOperate, value.m_regularTimeToOperate)) return false;
            if (!Utils.IsEqual(m_modePowerConsumption, value.m_modePowerConsumption)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (EnergyStateInformationDataType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnergyStateInformationDataType clone = (EnergyStateInformationDataType)base.MemberwiseClone();

            clone.m_iDSource = (byte)Utils.Clone(this.m_iDSource);
            clone.m_iDDestination = (byte)Utils.Clone(this.m_iDDestination);
            clone.m_regularTimeToOperate = (double)Utils.Clone(this.m_regularTimeToOperate);
            clone.m_modePowerConsumption = (float)Utils.Clone(this.m_modePowerConsumption);

            return clone;
        }
        #endregion

        #region Private Fields
        private byte m_iDSource;
        private byte m_iDDestination;
        private double m_regularTimeToOperate;
        private float m_modePowerConsumption;
        #endregion
    }

    #region EnergyStateInformationDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfEnergyStateInformationDataType", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "EnergyStateInformationDataType")]
    public partial class EnergyStateInformationDataTypeCollection : List<EnergyStateInformationDataType>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public EnergyStateInformationDataTypeCollection() {}

        /// <remarks />
        public EnergyStateInformationDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public EnergyStateInformationDataTypeCollection(IEnumerable<EnergyStateInformationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator EnergyStateInformationDataTypeCollection(EnergyStateInformationDataType[] values)
        {
            if (values != null)
            {
                return new EnergyStateInformationDataTypeCollection(values);
            }

            return new EnergyStateInformationDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator EnergyStateInformationDataType[](EnergyStateInformationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (EnergyStateInformationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnergyStateInformationDataTypeCollection clone = new EnergyStateInformationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((EnergyStateInformationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PeVersionDataType Class
    #if (!OPCUA_EXCLUDE_PeVersionDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public partial class PeVersionDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public PeVersionDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_majorVersion = (byte)0;
            m_minorVersion = (byte)0;
            m_revision = (byte)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "MajorVersion", IsRequired = false, Order = 1)]
        public byte MajorVersion
        {
            get { return m_majorVersion;  }
            set { m_majorVersion = value; }
        }

        /// <remarks />
        [DataMember(Name = "MinorVersion", IsRequired = false, Order = 2)]
        public byte MinorVersion
        {
            get { return m_minorVersion;  }
            set { m_minorVersion = value; }
        }

        /// <remarks />
        [DataMember(Name = "Revision", IsRequired = false, Order = 3)]
        public byte Revision
        {
            get { return m_revision;  }
            set { m_revision = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.PeVersionDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.PeVersionDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.PeVersionDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.PeVersionDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            encoder.WriteByte("MajorVersion", MajorVersion);
            encoder.WriteByte("MinorVersion", MinorVersion);
            encoder.WriteByte("Revision", Revision);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            MajorVersion = decoder.ReadByte("MajorVersion");
            MinorVersion = decoder.ReadByte("MinorVersion");
            Revision = decoder.ReadByte("Revision");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PeVersionDataType value = encodeable as PeVersionDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_majorVersion, value.m_majorVersion)) return false;
            if (!Utils.IsEqual(m_minorVersion, value.m_minorVersion)) return false;
            if (!Utils.IsEqual(m_revision, value.m_revision)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (PeVersionDataType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PeVersionDataType clone = (PeVersionDataType)base.MemberwiseClone();

            clone.m_majorVersion = (byte)Utils.Clone(this.m_majorVersion);
            clone.m_minorVersion = (byte)Utils.Clone(this.m_minorVersion);
            clone.m_revision = (byte)Utils.Clone(this.m_revision);

            return clone;
        }
        #endregion

        #region Private Fields
        private byte m_majorVersion;
        private byte m_minorVersion;
        private byte m_revision;
        #endregion
    }

    #region PeVersionDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPeVersionDataType", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "PeVersionDataType")]
    public partial class PeVersionDataTypeCollection : List<PeVersionDataType>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public PeVersionDataTypeCollection() {}

        /// <remarks />
        public PeVersionDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PeVersionDataTypeCollection(IEnumerable<PeVersionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PeVersionDataTypeCollection(PeVersionDataType[] values)
        {
            if (values != null)
            {
                return new PeVersionDataTypeCollection(values);
            }

            return new PeVersionDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator PeVersionDataType[](PeVersionDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PeVersionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PeVersionDataTypeCollection clone = new PeVersionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PeVersionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region StandbyModeTransitionDataType Class
    #if (!OPCUA_EXCLUDE_StandbyModeTransitionDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.PnEm.Namespaces.PnEm)]
    public partial class StandbyModeTransitionDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public StandbyModeTransitionDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_iDDestination = (byte)0;
            m_currentTimeToDestination = (double)0;
            m_currentTimeToOperate = (double)0;
            m_energyConsumptionToDestination = (float)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "IDDestination", IsRequired = false, Order = 1)]
        public byte IDDestination
        {
            get { return m_iDDestination;  }
            set { m_iDDestination = value; }
        }

        /// <remarks />
        [DataMember(Name = "CurrentTimeToDestination", IsRequired = false, Order = 2)]
        public double CurrentTimeToDestination
        {
            get { return m_currentTimeToDestination;  }
            set { m_currentTimeToDestination = value; }
        }

        /// <remarks />
        [DataMember(Name = "CurrentTimeToOperate", IsRequired = false, Order = 3)]
        public double CurrentTimeToOperate
        {
            get { return m_currentTimeToOperate;  }
            set { m_currentTimeToOperate = value; }
        }

        /// <remarks />
        [DataMember(Name = "EnergyConsumptionToDestination", IsRequired = false, Order = 4)]
        public float EnergyConsumptionToDestination
        {
            get { return m_energyConsumptionToDestination;  }
            set { m_energyConsumptionToDestination = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.StandbyModeTransitionDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.StandbyModeTransitionDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.StandbyModeTransitionDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.StandbyModeTransitionDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            encoder.WriteByte("IDDestination", IDDestination);
            encoder.WriteDouble("CurrentTimeToDestination", CurrentTimeToDestination);
            encoder.WriteDouble("CurrentTimeToOperate", CurrentTimeToOperate);
            encoder.WriteFloat("EnergyConsumptionToDestination", EnergyConsumptionToDestination);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.PnEm.Namespaces.PnEm);

            IDDestination = decoder.ReadByte("IDDestination");
            CurrentTimeToDestination = decoder.ReadDouble("CurrentTimeToDestination");
            CurrentTimeToOperate = decoder.ReadDouble("CurrentTimeToOperate");
            EnergyConsumptionToDestination = decoder.ReadFloat("EnergyConsumptionToDestination");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            StandbyModeTransitionDataType value = encodeable as StandbyModeTransitionDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_iDDestination, value.m_iDDestination)) return false;
            if (!Utils.IsEqual(m_currentTimeToDestination, value.m_currentTimeToDestination)) return false;
            if (!Utils.IsEqual(m_currentTimeToOperate, value.m_currentTimeToOperate)) return false;
            if (!Utils.IsEqual(m_energyConsumptionToDestination, value.m_energyConsumptionToDestination)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (StandbyModeTransitionDataType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            StandbyModeTransitionDataType clone = (StandbyModeTransitionDataType)base.MemberwiseClone();

            clone.m_iDDestination = (byte)Utils.Clone(this.m_iDDestination);
            clone.m_currentTimeToDestination = (double)Utils.Clone(this.m_currentTimeToDestination);
            clone.m_currentTimeToOperate = (double)Utils.Clone(this.m_currentTimeToOperate);
            clone.m_energyConsumptionToDestination = (float)Utils.Clone(this.m_energyConsumptionToDestination);

            return clone;
        }
        #endregion

        #region Private Fields
        private byte m_iDDestination;
        private double m_currentTimeToDestination;
        private double m_currentTimeToOperate;
        private float m_energyConsumptionToDestination;
        #endregion
    }

    #region StandbyModeTransitionDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfStandbyModeTransitionDataType", Namespace = Opc.Ua.PnEm.Namespaces.PnEm, ItemName = "StandbyModeTransitionDataType")]
    public partial class StandbyModeTransitionDataTypeCollection : List<StandbyModeTransitionDataType>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public StandbyModeTransitionDataTypeCollection() {}

        /// <remarks />
        public StandbyModeTransitionDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public StandbyModeTransitionDataTypeCollection(IEnumerable<StandbyModeTransitionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator StandbyModeTransitionDataTypeCollection(StandbyModeTransitionDataType[] values)
        {
            if (values != null)
            {
                return new StandbyModeTransitionDataTypeCollection(values);
            }

            return new StandbyModeTransitionDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator StandbyModeTransitionDataType[](StandbyModeTransitionDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (StandbyModeTransitionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            StandbyModeTransitionDataTypeCollection clone = new StandbyModeTransitionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((StandbyModeTransitionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}
// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.us.Common;
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>A StudentRecordExchange</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class StudentRecordExchange : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentRecordExchange
	/// </summary>
	public StudentRecordExchange() : base( Adk.SifVersion, EtranscriptsDTD.STUDENTRECORDEXCHANGE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of this object.</param>
	///
	public StudentRecordExchange( string refId ) : base( Adk.SifVersion, EtranscriptsDTD.STUDENTRECORDEXCHANGE )
	{
		this.RefId = refId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentRecordExchange( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { EtranscriptsDTD.STUDENTRECORDEXCHANGE_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of this object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.STUDENTRECORDEXCHANGE_REFID ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.STUDENTRECORDEXCHANGE_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A unique student identifier outside of SIF."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.STUDENTRECORDEXCHANGE_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.STUDENTRECORDEXCHANGE_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A locally-defined student identifier."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.STUDENTRECORDEXCHANGE_LOCALID ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.STUDENTRECORDEXCHANGE_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentPersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An associated StudentPersonal object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.STUDENTRECORDEXCHANGE_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.STUDENTRECORDEXCHANGE_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Records&gt;</c> element.
	/// </summary>
	/// <value> A Records </value>
	/// <remarks>
	/// <para>To remove the <c>Records</c>, set <c>Records</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Records Records
	{
		get
		{
			return (Records)GetChild( EtranscriptsDTD.STUDENTRECORDEXCHANGE_RECORDS);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTRECORDEXCHANGE_RECORDS);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTRECORDEXCHANGE_RECORDS, value );
			}
		}
	}

}}

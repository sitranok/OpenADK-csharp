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

namespace OpenADK.Library.us.Common{

/// <summary>A Service</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Service : SifElement
{
	/// <summary>
	/// Creates an instance of a Service
	/// </summary>
	public Service() : base ( CommonDTD.SERVICE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">Specialized instruction or related / transitional service provided to this student.</param>
	///<param name="codeType">(SIF 1.5r1 Only) Values: "NCES","StateDOE","Local","Text"</param>
	///<param name="type">InstructionalService, RelatedService, Other</param>
	///
	public Service( ServiceCode code, string codeType, string type ) : base( CommonDTD.SERVICE )
	{
		this.SetCode( code );
		this.CodeType = codeType;
		this.Type = type;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Service( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specialized instruction or related / transitional service provided to this student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( CommonDTD.SERVICE_CODE );
		}
		set
		{
			SetField( CommonDTD.SERVICE_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A ServiceCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specialized instruction or related / transitional service provided to this student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCode( ServiceCode val )
	{
		SetField( CommonDTD.SERVICE_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>CodeType</c> attribute.
	/// </summary>
	/// <value> The <c>CodeType</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "(SIF 1.5r1 Only) Values: "NCES","StateDOE","Local","Text""</para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string CodeType
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SERVICE_CODETYPE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SERVICE_CODETYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "InstructionalService, RelatedService, Other"</para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Type
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SERVICE_TYPE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SERVICE_TYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( CommonDTD.SERVICE_OTHERCODELIST);
		}
		set
		{
			RemoveChild( CommonDTD.SERVICE_OTHERCODELIST);
			if( value != null)
			{
				AddChild( CommonDTD.SERVICE_OTHERCODELIST, value );
			}
		}
	}

}}

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

namespace OpenADK.Library.us.Student{

/// <summary>This element is mutually exclusive with Nonpromotion, and its child elements should only be populated if the value of PromotionStatus is "Promoted".</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class Promotion : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Promotion
	/// </summary>
	public Promotion() : base ( StudentDTD.PROMOTION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">The reason the student was promoted. This element should only be populated if the value of PromotionStatus is "Promoted".</param>
	///
	public Promotion( NCES0672PromotionType code ) : base( StudentDTD.PROMOTION )
	{
		this.SetCode( code );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Promotion( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.PROMOTION_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The reason the student was promoted. This element should only be populated if the value of PromotionStatus is "Promoted"."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( StudentDTD.PROMOTION_CODE );
		}
		set
		{
			SetField( StudentDTD.PROMOTION_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A NCES0672PromotionType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The reason the student was promoted. This element should only be populated if the value of PromotionStatus is "Promoted"."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetCode( NCES0672PromotionType val )
	{
		SetField( StudentDTD.PROMOTION_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( StudentDTD.PROMOTION_OTHERCODELIST);
		}
		set
		{
			RemoveChild( StudentDTD.PROMOTION_OTHERCODELIST);
			if( value != null)
			{
				AddChild( StudentDTD.PROMOTION_OTHERCODELIST, value );
			}
		}
	}

}}

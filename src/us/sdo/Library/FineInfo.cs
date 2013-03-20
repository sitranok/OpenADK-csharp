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

namespace OpenADK.Library.us.Library{

/// <summary>A FineInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class FineInfo : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a FineInfo
	/// </summary>
	public FineInfo() : base ( LibraryDTD.FINEINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">Type of fine assessed to this patron and item.  A corresponding ItemInfo is required for all FineInfo types except "Other" and "Refund" where it is permissible to omit the ItemInfo element if there isn't an item associated with the fine.</param>
	///<param name="assessed">The date and time that this fine was assessed to the patron.</param>
	///<param name="amount">The current balance of the fine expressed as a positive number. </param>
	///
	public FineInfo( FineType type, DateTime? assessed, MonetaryAmount amount ) : base( LibraryDTD.FINEINFO )
	{
		this.SetType( type );
		this.Assessed = assessed;
		this.Amount = amount;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FineInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LibraryDTD.FINEINFO_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Type of fine assessed to this patron and item.  A corresponding ItemInfo is required for all FineInfo types except "Other" and "Refund" where it is permissible to omit the ItemInfo element if there isn't an item associated with the fine."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( LibraryDTD.FINEINFO_TYPE );
		}
		set
		{
			SetField( LibraryDTD.FINEINFO_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <param name="val">A FineType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Type of fine assessed to this patron and item.  A corresponding ItemInfo is required for all FineInfo types except "Other" and "Refund" where it is permissible to omit the ItemInfo element if there isn't an item associated with the fine."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetType( FineType val )
	{
		SetField( LibraryDTD.FINEINFO_TYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Assessed&gt;</c> element.
	/// </summary>
	/// <value> The <c>Assessed</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date and time that this fine was assessed to the patron."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Assessed&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public DateTime? Assessed
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LibraryDTD.FINEINFO_ASSESSED ) ;
		}
		set
		{
			SetFieldValue( LibraryDTD.FINEINFO_ASSESSED, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "More detailed information concerning the assessed fine or refund."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LibraryDTD.FINEINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( LibraryDTD.FINEINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Amount&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;MonetaryAmount&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAmount</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Amount</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetAmount( decimal? Value ) {
		RemoveChild( LibraryDTD.FINEINFO_AMOUNT);
		AddChild( LibraryDTD.FINEINFO_AMOUNT, new MonetaryAmount( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Amount&gt;</c> element.
	/// </summary>
	/// <value> A MonetaryAmount </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The current balance of the fine expressed as a positive number. "</para>
	/// <para>To remove the <c>MonetaryAmount</c>, set <c>Amount</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public MonetaryAmount Amount
	{
		get
		{
			return (MonetaryAmount)GetChild( LibraryDTD.FINEINFO_AMOUNT);
		}
		set
		{
			RemoveChild( LibraryDTD.FINEINFO_AMOUNT);
			if( value != null)
			{
				AddChild( LibraryDTD.FINEINFO_AMOUNT, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Reference&gt;</c> element.
	/// </summary>
	/// <value> The <c>Reference</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An application-specific reference identifier for the fine being assessed, paid, or refunded.  It is intended to identify a specific fine transaction allowing consumers to include this information in Billing or Payment events sent to the library application."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Reference
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LibraryDTD.FINEINFO_REFERENCE ) ;
		}
		set
		{
			SetFieldValue( LibraryDTD.FINEINFO_REFERENCE, new SifString( value ), value );
		}
	}

}}

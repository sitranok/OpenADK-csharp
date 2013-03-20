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

namespace OpenADK.Library.us.Hrfin{

/// <summary>Contains information about an item being purchased</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class PurchasingItem : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a PurchasingItem
	/// </summary>
	public PurchasingItem() : base ( HrfinDTD.PURCHASINGITEM ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="itemDescription">Description of the item.</param>
	///
	public PurchasingItem( string itemDescription ) : base( HrfinDTD.PURCHASINGITEM )
	{
		this.ItemDescription = itemDescription;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PurchasingItem( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.PURCHASINGITEM_ITEMDESCRIPTION }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Vendor item number."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string ItemNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.PURCHASINGITEM_ITEMNUMBER ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PURCHASINGITEM_ITEMNUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemDescription&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemDescription</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description of the item."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string ItemDescription
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.PURCHASINGITEM_ITEMDESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PURCHASINGITEM_ITEMDESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Quantity&gt;</c> element.
	/// </summary>
	/// <value> The <c>Quantity</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Quantity ordered."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Quantity
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.PURCHASINGITEM_QUANTITY ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PURCHASINGITEM_QUANTITY, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;UnitCost&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;MonetaryAmount&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setUnitCost</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>UnitCost</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetUnitCost( decimal? Value ) {
		RemoveChild( HrfinDTD.PURCHASINGITEM_UNITCOST);
		AddChild( HrfinDTD.PURCHASINGITEM_UNITCOST, new MonetaryAmount( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;UnitCost&gt;</c> element.
	/// </summary>
	/// <value> A MonetaryAmount </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Unit cost of the item."</para>
	/// <para>To remove the <c>MonetaryAmount</c>, set <c>UnitCost</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public MonetaryAmount UnitCost
	{
		get
		{
			return (MonetaryAmount)GetChild( HrfinDTD.PURCHASINGITEM_UNITCOST);
		}
		set
		{
			RemoveChild( HrfinDTD.PURCHASINGITEM_UNITCOST);
			if( value != null)
			{
				AddChild( HrfinDTD.PURCHASINGITEM_UNITCOST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ExpenseAccounts&gt;</c> element.
	/// </summary>
	/// <value> An ExpenseAccounts </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Account that is to be charged for the item."</para>
	/// <para>To remove the <c>ExpenseAccounts</c>, set <c>ExpenseAccounts</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public ExpenseAccounts ExpenseAccounts
	{
		get
		{
			return (ExpenseAccounts)GetChild( HrfinDTD.PURCHASINGITEM_EXPENSEACCOUNTS);
		}
		set
		{
			RemoveChild( HrfinDTD.PURCHASINGITEM_EXPENSEACCOUNTS);
			if( value != null)
			{
				AddChild( HrfinDTD.PURCHASINGITEM_EXPENSEACCOUNTS, value );
			}
		}
	}

}}

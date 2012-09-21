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

namespace OpenADK.Library.us.Datamodel{

/// <summary>This object is designed to facilitate the transfer of State Education Agency (SEA) directory information to the Department of Education (USED) through the Education Data Exchange Network (EDEN).</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class SEAInfo : SifElement
{
	/// <summary>
	/// Creates an instance of a SEAInfo
	/// </summary>
	public SEAInfo() : base ( DatamodelDTD.SEAINFO ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SEAInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.SEAINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.SEAINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-assigned identifier for this SEA."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.SEAINFO_LOCALID ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.SEAINFO_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NCESId&gt;</c> element.
	/// </summary>
	/// <value> The <c>NCESId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The NCES-assigned identifier for this SEA."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string NCESId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.SEAINFO_NCESID ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.SEAINFO_NCESID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SEAName&gt;</c> element.
	/// </summary>
	/// <value> The <c>SEAName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The full legally accepted name of the SEA."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SEAName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.SEAINFO_SEANAME ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.SEAINFO_SEANAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SEAURL&gt;</c> element.
	/// </summary>
	/// <value> The <c>SEAURL</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "URL for the SEA."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SEAURL
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.SEAINFO_SEAURL ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.SEAINFO_SEAURL, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;CSSOContact&gt;</c> element.</summary>
	/// <param name="Name">The name of the contact person.</param>
	///<remarks>
	/// <para>This form of <c>setCSSOContact</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>CSSOContact</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetCSSOContact( Name Name ) {
		RemoveChild( DatamodelDTD.SEAINFO_CSSOCONTACT);
		AddChild( DatamodelDTD.SEAINFO_CSSOCONTACT, new ContactInfo( Name ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CSSOContact&gt;</c> element.
	/// </summary>
	/// <value> A ContactInfo </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Chief State School Officer contact information."</para>
	/// <para>To remove the <c>ContactInfo</c>, set <c>CSSOContact</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ContactInfo CSSOContact
	{
		get
		{
			return (ContactInfo)GetChild( DatamodelDTD.SEAINFO_CSSOCONTACT);
		}
		set
		{
			RemoveChild( DatamodelDTD.SEAINFO_CSSOCONTACT);
			if( value != null)
			{
				AddChild( DatamodelDTD.SEAINFO_CSSOCONTACT, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SEAContactList&gt;</c> element.
	/// </summary>
	/// <value> A SEAContactList </value>
	/// <remarks>
	/// <para>To remove the <c>SEAContactList</c>, set <c>SEAContactList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SEAContactList SEAContactList
	{
		get
		{
			return (SEAContactList)GetChild( DatamodelDTD.SEAINFO_SEACONTACTLIST);
		}
		set
		{
			RemoveChild( DatamodelDTD.SEAINFO_SEACONTACTLIST);
			if( value != null)
			{
				AddChild( DatamodelDTD.SEAINFO_SEACONTACTLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.
	/// </summary>
	/// <value> A PhoneNumberList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The SEA's phone number(s)."</para>
	/// <para>To remove the <c>PhoneNumberList</c>, set <c>PhoneNumberList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PhoneNumberList PhoneNumberList
	{
		get
		{
			return (PhoneNumberList)GetChild( DatamodelDTD.SEAINFO_PHONENUMBERLIST);
		}
		set
		{
			RemoveChild( DatamodelDTD.SEAINFO_PHONENUMBERLIST);
			if( value != null)
			{
				AddChild( DatamodelDTD.SEAINFO_PHONENUMBERLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AddressList&gt;</c> element.
	/// </summary>
	/// <value> An AddressList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The SEA's address(es)."</para>
	/// <para>To remove the <c>AddressList</c>, set <c>AddressList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public AddressList AddressList
	{
		get
		{
			return (AddressList)GetChild( DatamodelDTD.SEAINFO_ADDRESSLIST);
		}
		set
		{
			RemoveChild( DatamodelDTD.SEAINFO_ADDRESSLIST);
			if( value != null)
			{
				AddChild( DatamodelDTD.SEAINFO_ADDRESSLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OperationalStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>OperationalStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Operational condition of an SEA."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string OperationalStatus
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.SEAINFO_OPERATIONALSTATUS ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.SEAINFO_OPERATIONALSTATUS, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EDENInfo&gt;</c> element.
	/// </summary>
	/// <value> An EDENInfoType </value>
	/// <remarks>
	/// <para>To remove the <c>EDENInfoType</c>, set <c>EDENInfo</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public EDENInfoType EDENInfo
	{
		get
		{
			return (EDENInfoType)GetChild( DatamodelDTD.SEAINFO_EDENINFO);
		}
		set
		{
			RemoveChild( DatamodelDTD.SEAINFO_EDENINFO);
			if( value != null)
			{
				AddChild( DatamodelDTD.SEAINFO_EDENINFO, value );
			}
		}
	}

}}
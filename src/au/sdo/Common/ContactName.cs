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

namespace OpenADK.Library.au.Common{

/// <summary>A ContactName</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class ContactName : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ContactName
	/// </summary>
	public ContactName() : base ( CommonDTD.CONTACTNAME ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">A Type</param>
	///
	public ContactName( string type ) : base( CommonDTD.CONTACTNAME )
	{
		this.Type = type;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ContactName( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.CONTACTNAME_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Type
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_TYPE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_TYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A title or prefix associated with the name. If any of: Mr, Mrs, Ms, Miss, Rev, Fr, Dr, Prof, Hon, Sir, Lord, Lady - these must be as shown, otherwise free text. Note that title is not applicable to learners."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Title
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_TITLE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_TITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FamilyName&gt;</c> element.
	/// </summary>
	/// <value> The <c>FamilyName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Family name. That part of the person's name which is used to describe family, clan, tribal group, or marital association. Note that this element is required when known. However, it may not be possible to know the family name in which case you should add the available information to the FullName element."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string FamilyName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_FAMILYNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_FAMILYNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GivenName&gt;</c> element.
	/// </summary>
	/// <value> The <c>GivenName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Given name of the person. Note that this element is required if known. However, it may not be possible to know the given name in which case you should add the available information to the FullName element."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string GivenName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_GIVENNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_GIVENNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MiddleName&gt;</c> element.
	/// </summary>
	/// <value> The <c>MiddleName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "All other given or middle names, each separated with a single space character."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string MiddleName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_MIDDLENAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_MIDDLENAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FamilyNameFirst&gt;</c> element.
	/// </summary>
	/// <value> The <c>FamilyNameFirst</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indicator used to identify the naming conventions used by some predominantly non-European, ethnic or language groups and related to the display nature of a name."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string FamilyNameFirst
	{
		get
		{ 
			return GetFieldValue( CommonDTD.CONTACTNAME_FAMILYNAMEFIRST );
		}
		set
		{
			SetField( CommonDTD.CONTACTNAME_FAMILYNAMEFIRST, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;FamilyNameFirst&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indicator used to identify the naming conventions used by some predominantly non-European, ethnic or language groups and related to the display nature of a name."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetFamilyNameFirst( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( CommonDTD.CONTACTNAME_FAMILYNAMEFIRST, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PreferredFamilyName&gt;</c> element.
	/// </summary>
	/// <value> The <c>PreferredFamilyName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The family name preferred most by the person (as written)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string PreferredFamilyName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_PREFERREDFAMILYNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_PREFERREDFAMILYNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PreferredFamilyNameFirst&gt;</c> element.
	/// </summary>
	/// <value> The <c>PreferredFamilyNameFirst</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indicator used to identify the naming conventions used by some predominantly non-European, ethnic or language groups and related to the display nature of a name."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string PreferredFamilyNameFirst
	{
		get
		{ 
			return GetFieldValue( CommonDTD.CONTACTNAME_PREFERREDFAMILYNAMEFIRST );
		}
		set
		{
			SetField( CommonDTD.CONTACTNAME_PREFERREDFAMILYNAMEFIRST, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;PreferredFamilyNameFirst&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indicator used to identify the naming conventions used by some predominantly non-European, ethnic or language groups and related to the display nature of a name."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPreferredFamilyNameFirst( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( CommonDTD.CONTACTNAME_PREFERREDFAMILYNAMEFIRST, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PreferredGivenName&gt;</c> element.
	/// </summary>
	/// <value> The <c>PreferredGivenName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The given name preferred most by the person (as written)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string PreferredGivenName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_PREFERREDGIVENNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_PREFERREDGIVENNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Suffix&gt;</c> element.
	/// </summary>
	/// <value> The <c>Suffix</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Textual suffix like PHD, JP, BSc."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Suffix
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_SUFFIX ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_SUFFIX, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FullName&gt;</c> element.
	/// </summary>
	/// <value> The <c>FullName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A free text field for the complete name for display purposes. If this is associated with a StudentPersonal,StaffPersonal or StudentContactPersonal record and the FamilyName and GivenName are not both specified, then this becomes mandatory."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string FullName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTNAME_FULLNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTNAME_FULLNAME, new SifString( value ), value );
		}
	}

}}

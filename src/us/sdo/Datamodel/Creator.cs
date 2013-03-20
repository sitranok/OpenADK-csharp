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

/// <summary>A Creator</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Creator : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Creator
	/// </summary>
	public Creator() : base ( DatamodelDTD.CREATOR ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="name">Human-readable name of the data's creator. If the object contains system-generated data, the name should identify the creating service or application.</param>
	///<param name="id">Unique identifier of the creator. An email address or URI could be used here.</param>
	///
	public Creator( string name, string id ) : base( DatamodelDTD.CREATOR )
	{
		this.Name = name;
		this.ID = id;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Creator( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { DatamodelDTD.CREATOR_ID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Human-readable name of the data's creator. If the object contains system-generated data, the name should identify the creating service or application."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.CREATOR_NAME ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.CREATOR_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ID&gt;</c> element.
	/// </summary>
	/// <value> The <c>ID</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Unique identifier of the creator. An email address or URI could be used here."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string ID
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.CREATOR_ID ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.CREATOR_ID, new SifString( value ), value );
		}
	}

}}

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

/// <summary>A ResourceTypes</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class ResourceTypes : SifKeyedList<ResourceTypeType>
{
	/// <summary>
	/// Creates an instance of a ResourceTypes
	/// </summary>
	public ResourceTypes() : base ( DatamodelDTD.RESOURCETYPES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="resourceType">A ResourceType</param>
	///
	public ResourceTypes( ResourceTypeType resourceType ) : base( DatamodelDTD.RESOURCETYPES )
	{
		this.SafeAddChild( DatamodelDTD.RESOURCETYPES_RESOURCETYPE, resourceType );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ResourceTypes( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { DatamodelDTD.RESOURCETYPES_RESOURCETYPE }; }
	}

	///<summary>Adds the value of the <c>&lt;ResourceType&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ResourceTypeType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setResourceType</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddResourceType</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddResourceType( string Value ) {
		AddChild( DatamodelDTD.RESOURCETYPES_RESOURCETYPE, new ResourceTypeType( Value ) );
	}

}}

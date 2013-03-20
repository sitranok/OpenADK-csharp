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

namespace OpenADK.Library.Infra{

/// <summary>A SIF_AddPublishers</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SIF_AddPublishers : SifKeyedList<SIF_Publisher>
{
	/// <summary>
	/// Creates an instance of a SIF_AddPublishers
	/// </summary>
	public SIF_AddPublishers() : base ( InfraDTD.SIF_ADDPUBLISHERS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifPublisher">A SIF_Publisher</param>
	///
	public SIF_AddPublishers( SIF_Publisher sifPublisher ) : base( InfraDTD.SIF_ADDPUBLISHERS )
	{
		this.SafeAddChild( InfraDTD.SIF_ADDPUBLISHERS_SIF_PUBLISHER, sifPublisher );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_AddPublishers( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;SIF_Publisher&gt;</c> element.</summary>
	/// <param name="SourceId">The identifier of the SIF node that is providing objects. This is the agent or ZIS identifier that would appear in the SIF_SourceId field of any SIF_Header created by the SIF node.</param>
	///<remarks>
	/// <para>This form of <c>setSIF_Publisher</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSIF_Publisher</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddSIF_Publisher( string SourceId ) {
		AddChild( InfraDTD.SIF_ADDPUBLISHERS_SIF_PUBLISHER, new SIF_Publisher( SourceId ) );
	}

}}

﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal enum MessageID
    {
        MessageBase = 1200,
        IDS_SK_METHOD = MessageBase + 2000,
        IDS_SK_TYPE = MessageBase + 2001,
        IDS_SK_NAMESPACE = MessageBase + 2002,
        IDS_SK_FIELD = MessageBase + 2003,
        IDS_SK_PROPERTY = MessageBase + 2004,
        IDS_SK_UNKNOWN = MessageBase + 2005,
        IDS_SK_VARIABLE = MessageBase + 2006,
        IDS_SK_EVENT = MessageBase + 2007,
        IDS_SK_TYVAR = MessageBase + 2008,
        //IDS_SK_GCLASS = MessageBase + 2009,
        IDS_SK_ALIAS = MessageBase + 2010,
        //IDS_SK_EXTERNALIAS = MessageBase + 2011,
        IDS_SK_LABEL = MessageBase + 2012,
        IDS_NULL = MessageBase + 10001,
        //IDS_RELATEDERROR = MessageBase + 10002,
        //IDS_RELATEDWARNING = MessageBase + 10003,
        IDS_XMLIGNORED = MessageBase + 10004,
        IDS_XMLIGNORED2 = MessageBase + 10005,
        IDS_XMLFAILEDINCLUDE = MessageBase + 10006,
        IDS_XMLBADINCLUDE = MessageBase + 10007,
        IDS_XMLNOINCLUDE = MessageBase + 10008,
        IDS_XMLMISSINGINCLUDEFILE = MessageBase + 10009,
        IDS_XMLMISSINGINCLUDEPATH = MessageBase + 10010,
        IDS_GlobalNamespace = MessageBase + 10011,
        IDS_FeatureGenerics = MessageBase + 12500,
        IDS_FeatureAnonDelegates = MessageBase + 12501,
        IDS_FeatureModuleAttrLoc = MessageBase + 12502,
        IDS_FeatureGlobalNamespace = MessageBase + 12503,
        IDS_FeatureFixedBuffer = MessageBase + 12504,
        IDS_FeaturePragma = MessageBase + 12505,
        IDS_FOREACHLOCAL = MessageBase + 12506,
        IDS_USINGLOCAL = MessageBase + 12507,
        IDS_FIXEDLOCAL = MessageBase + 12508,
        IDS_FeatureStaticClasses = MessageBase + 12511,
        IDS_FeaturePartialTypes = MessageBase + 12512,
        IDS_MethodGroup = MessageBase + 12513,
        IDS_AnonMethod = MessageBase + 12514,
        IDS_FeatureSwitchOnBool = MessageBase + 12517,
        //IDS_WarnAsError = MessageBase + 12518,
        IDS_Collection = MessageBase + 12520,
        IDS_FeaturePropertyAccessorMods = MessageBase + 12522,
        IDS_FeatureExternAlias = MessageBase + 12523,
        IDS_FeatureIterators = MessageBase + 12524,
        IDS_FeatureDefault = MessageBase + 12525,
        IDS_FeatureNullable = MessageBase + 12528,
        IDS_Lambda = MessageBase + 12531,

        IDS_FeatureImplicitArray = MessageBase + 12557,
        IDS_FeatureImplicitLocal = MessageBase + 12558,
        IDS_FeatureAnonymousTypes = MessageBase + 12559,
        IDS_FeatureAutoImplementedProperties = MessageBase + 12560,
        IDS_FeatureObjectInitializer = MessageBase + 12561,
        IDS_FeatureCollectionInitializer = MessageBase + 12562,
        IDS_FeatureLambda = MessageBase + 12563,
        IDS_FeatureQueryExpression = MessageBase + 12564,
        IDS_FeatureExtensionMethod = MessageBase + 12565,
        IDS_FeaturePartialMethod = MessageBase + 12566,
        IDS_FeatureDynamic = MessageBase + 12644,
        IDS_FeatureTypeVariance = MessageBase + 12645,
        IDS_FeatureNamedArgument = MessageBase + 12646,
        IDS_FeatureOptionalParameter = MessageBase + 12647,
        IDS_FeatureExceptionFilter = MessageBase + 12648,
        IDS_FeatureAutoPropertyInitializer = MessageBase + 12649,

        IDS_SK_TYPE_OR_NAMESPACE = MessageBase + 12652,
        IDS_Contravariant = MessageBase + 12659,
        IDS_Contravariantly = MessageBase + 12660,
        IDS_Covariant = MessageBase + 12661,
        IDS_Covariantly = MessageBase + 12662,
        IDS_Invariantly = MessageBase + 12663,

        IDS_FeatureAsync = MessageBase + 12668,

        IDS_LIB_ENV = MessageBase + 12680,
        IDS_LIB_OPTION = MessageBase + 12681,
        IDS_REFERENCEPATH_OPTION = MessageBase + 12682,
        IDS_DirectoryDoesNotExist = MessageBase + 12683,
        IDS_DirectoryHasInvalidPath = MessageBase + 12684,

        IDS_Namespace1 = MessageBase + 12685,
        IDS_PathList = MessageBase + 12686,
        IDS_Text = MessageBase + 12687,

        // available

        IDS_FeatureNullPropagatingOperator = MessageBase + 12690,
        IDS_FeatureExpressionBodiedMethod = MessageBase + 12691,
        IDS_FeatureExpressionBodiedProperty = MessageBase + 12692,
        IDS_FeatureExpressionBodiedIndexer = MessageBase + 12693,
        // IDS_VersionExperimental = MessageBase + 12694,
        IDS_FeatureNameof = MessageBase + 12695,
        IDS_FeatureDictionaryInitializer = MessageBase + 12696,

        IDS_ToolName = MessageBase + 12697,
        IDS_LogoLine1 = MessageBase + 12698,
        IDS_LogoLine2 = MessageBase + 12699,
        IDS_CSCHelp = MessageBase + 12700,

        IDS_FeatureUsingStatic = MessageBase + 12701,
        IDS_FeatureInterpolatedStrings = MessageBase + 12702,
        IDS_OperationCausedStackOverflow = MessageBase + 12703,
        IDS_AwaitInCatchAndFinally = MessageBase + 12704,
        IDS_FeatureReadonlyAutoImplementedProperties = MessageBase + 12705,
        
        IDS_FeatureIOperation = MessageBase + 12706,
    }

        
}
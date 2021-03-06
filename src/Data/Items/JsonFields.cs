﻿namespace Sitecore.Data.Items
{
  using Sitecore.Data.Collections;
  using Sitecore.Data.Helpers;

  public class JsonFields
  {
    [NotNull]
    public readonly JsonFieldsCollection Shared = new JsonFieldsCollection();

    [NotNull]
    public readonly JsonUnversionedFieldsCollection Unversioned = new JsonUnversionedFieldsCollection();

    [NotNull]
    public readonly JsonLanguageCollection Versioned = new JsonLanguageCollection();
  }
}
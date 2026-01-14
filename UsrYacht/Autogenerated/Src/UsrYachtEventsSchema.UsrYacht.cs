namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a828bcd5-2fcb-4906-a898-fa80aafd5c7c");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c878a6d7-5dd9-4615-aa29-0533591f80af");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,110,219,48,12,189,23,232,63,112,62,217,64,160,229,178,75,187,21,88,178,108,40,80,180,195,236,12,24,134,29,20,153,113,52,200,146,33,201,201,178,34,255,62,202,114,90,199,233,128,242,98,147,124,122,124,143,160,230,53,186,134,11,132,2,173,229,206,172,61,155,27,189,150,85,107,185,151,70,95,94,60,94,94,0,69,235,164,174,32,223,59,143,245,245,176,52,124,88,215,70,255,183,105,145,45,180,151,94,162,123,13,134,45,182,168,253,17,250,179,43,239,187,218,157,36,17,26,109,154,139,13,214,252,158,60,192,7,72,150,206,254,224,98,227,147,236,87,124,211,180,43,37,5,8,197,157,131,174,245,2,9,92,193,140,59,124,161,19,73,122,251,3,62,179,37,193,178,68,216,26,89,194,131,206,249,150,108,164,102,245,27,133,7,135,186,68,59,129,72,56,195,53,121,234,104,63,218,202,1,102,207,116,3,230,16,43,82,193,158,216,142,52,152,93,159,194,34,47,236,131,29,114,157,198,60,139,248,17,182,68,33,107,174,160,177,82,132,21,117,143,216,23,244,197,190,193,114,110,84,91,235,239,92,181,248,190,71,222,164,97,139,95,3,60,25,15,150,107,72,35,209,13,188,155,78,167,217,105,123,228,38,4,178,91,55,231,90,160,194,146,166,123,219,34,113,158,227,156,183,225,14,232,18,29,175,176,192,186,81,220,7,189,26,119,112,103,4,87,242,47,95,41,204,59,92,26,93,44,29,90,186,84,77,59,167,51,101,223,208,153,214,10,194,24,75,36,147,243,41,33,158,110,36,222,86,50,129,228,140,223,177,110,37,183,174,48,102,38,171,152,37,25,43,76,63,63,123,133,9,18,31,11,236,179,177,53,247,233,200,28,13,14,59,132,101,254,233,108,209,33,252,198,154,93,231,127,241,71,96,19,44,30,41,198,240,195,115,218,255,210,231,16,36,190,237,3,238,31,138,197,155,16,161,54,48,220,107,188,138,224,19,219,161,208,221,129,131,154,46,152,4,113,13,143,211,3,112,74,180,241,192,149,50,59,44,255,1,242,29,87,98,65,4,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("de24ff82-765a-3257-52b3-d689daf68bf7"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("c878a6d7-5dd9-4615-aa29-0533591f80af"),
				CreatedInSchemaUId = new Guid("a828bcd5-2fcb-4906-a898-fa80aafd5c7c"),
				ModifiedInSchemaUId = new Guid("a828bcd5-2fcb-4906-a898-fa80aafd5c7c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a828bcd5-2fcb-4906-a898-fa80aafd5c7c"));
		}

		#endregion

	}

	#endregion

}


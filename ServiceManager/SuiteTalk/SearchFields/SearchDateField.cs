//~ Generated by ISupportSearchValueNTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class SearchDateField 
		: ISupportSearchValue< DateTime? >,  
		  ISupportSearchOperator< com.celigo.net.ServiceManager.SuiteTalk.SearchDateFieldOperator >, 
		  ISupportSearchValue2< DateTime? >,
		  IBasicSearchField 
	{ 
		public DateTime? GetSearchValue()
		{
			if (!this.searchValueFieldSpecified)
			{
				return null;
			}
			return this.searchValue;
		}
		
				
		public void SetSearchValue(DateTime? value)
		{
			this.searchValue = value.GetValueOrDefault();
			this.searchValueSpecified = (null != value && value.HasValue); 			
		}
		
				
		public DateTime? GetSearchValue2()
		{
			if (!this.searchValue2FieldSpecified)
			{
				return null;
			}
			return this.searchValue2;
		}
		
		public void SetSearchValue2(DateTime? value)
		{
			this.searchValue2 = value.GetValueOrDefault();
			this.searchValue2Specified = (null != value && value.HasValue);			
		}		
	}
}


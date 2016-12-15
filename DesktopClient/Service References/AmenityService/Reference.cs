﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopClient.AmenityService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AmenityService.IAmenityService")]
    public interface IAmenityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmenityService/GetAllBedTypes", ReplyAction="http://tempuri.org/IAmenityService/GetAllBedTypesResponse")]
        DomainModel.DataContracts.BedTypeDto[] GetAllBedTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmenityService/GetAllBedTypes", ReplyAction="http://tempuri.org/IAmenityService/GetAllBedTypesResponse")]
        System.Threading.Tasks.Task<DomainModel.DataContracts.BedTypeDto[]> GetAllBedTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmenityService/GetAllBathroomTypes", ReplyAction="http://tempuri.org/IAmenityService/GetAllBathroomTypesResponse")]
        DomainModel.DataContracts.BathroomTypeDto[] GetAllBathroomTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmenityService/GetAllBathroomTypes", ReplyAction="http://tempuri.org/IAmenityService/GetAllBathroomTypesResponse")]
        System.Threading.Tasks.Task<DomainModel.DataContracts.BathroomTypeDto[]> GetAllBathroomTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmenityService/CreateBedType", ReplyAction="http://tempuri.org/IAmenityService/CreateBedTypeResponse")]
        bool CreateBedType(DomainModel.DataContracts.BedTypeDto bedTypeDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmenityService/CreateBedType", ReplyAction="http://tempuri.org/IAmenityService/CreateBedTypeResponse")]
        System.Threading.Tasks.Task<bool> CreateBedTypeAsync(DomainModel.DataContracts.BedTypeDto bedTypeDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmenityService/CreateBathroomType", ReplyAction="http://tempuri.org/IAmenityService/CreateBathroomTypeResponse")]
        bool CreateBathroomType(DomainModel.DataContracts.BathroomTypeDto bathroomTypeDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmenityService/CreateBathroomType", ReplyAction="http://tempuri.org/IAmenityService/CreateBathroomTypeResponse")]
        System.Threading.Tasks.Task<bool> CreateBathroomTypeAsync(DomainModel.DataContracts.BathroomTypeDto bathroomTypeDto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAmenityServiceChannel : DesktopClient.AmenityService.IAmenityService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AmenityServiceClient : System.ServiceModel.ClientBase<DesktopClient.AmenityService.IAmenityService>, DesktopClient.AmenityService.IAmenityService {
        
        public AmenityServiceClient() {
        }
        
        public AmenityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AmenityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AmenityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AmenityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DomainModel.DataContracts.BedTypeDto[] GetAllBedTypes() {
            return base.Channel.GetAllBedTypes();
        }
        
        public System.Threading.Tasks.Task<DomainModel.DataContracts.BedTypeDto[]> GetAllBedTypesAsync() {
            return base.Channel.GetAllBedTypesAsync();
        }
        
        public DomainModel.DataContracts.BathroomTypeDto[] GetAllBathroomTypes() {
            return base.Channel.GetAllBathroomTypes();
        }
        
        public System.Threading.Tasks.Task<DomainModel.DataContracts.BathroomTypeDto[]> GetAllBathroomTypesAsync() {
            return base.Channel.GetAllBathroomTypesAsync();
        }
        
        public bool CreateBedType(DomainModel.DataContracts.BedTypeDto bedTypeDto) {
            return base.Channel.CreateBedType(bedTypeDto);
        }
        
        public System.Threading.Tasks.Task<bool> CreateBedTypeAsync(DomainModel.DataContracts.BedTypeDto bedTypeDto) {
            return base.Channel.CreateBedTypeAsync(bedTypeDto);
        }
        
        public bool CreateBathroomType(DomainModel.DataContracts.BathroomTypeDto bathroomTypeDto) {
            return base.Channel.CreateBathroomType(bathroomTypeDto);
        }
        
        public System.Threading.Tasks.Task<bool> CreateBathroomTypeAsync(DomainModel.DataContracts.BathroomTypeDto bathroomTypeDto) {
            return base.Channel.CreateBathroomTypeAsync(bathroomTypeDto);
        }
    }
}

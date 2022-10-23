﻿
using StoreService.Model.Entities.Store;
using TakeFood.StoreService.ViewModel.Dtos.Store;

namespace StoreService.Service
{
    public interface IStoreService
    {
        List<Store> getAllStores();
        Task CreateStore(string ownerID, CreateStoreDto store);
    }
}

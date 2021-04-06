﻿using PaginationAndSearch.Client.Helpers;
using System.Threading.Tasks;

namespace PaginationAndSearch.Client.Interface
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<object>> Delete(string url);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T data);
    }
}
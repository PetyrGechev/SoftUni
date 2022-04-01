import * as api from './api.js'

const endpoints = {
    myBooks: (id)=>`/data/books?where=_ownerId%3D%22${id}%22&sortBy=_createdOn%20desc`,
     allBooks: '/data/books?sortBy=_createdOn%20desc',
     create: '/data/books',
     byId: '/data/books/',
    del: '/data/books/',
    edit: '/data/books/'

}

export async function getMybooks(id) {
    return api.get(endpoints.myBooks(id))
}

export async function getАll() {
    return api.get(endpoints.allBooks)
}

export async function create(data) {
    return api.post(endpoints.create, data)
}

export async function getById(id) {
    return api.get(endpoints.byId + id)
}

export async function deleteById(id) {
    return api.del(endpoints.del + id)
}
export async function editById(id,data) {
    return api.put(endpoints.edit + id,data)
}

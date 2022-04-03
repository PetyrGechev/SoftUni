//  import * as api from './api.js'

//  const endpoints = {
//     myBooks: (id)=>`/data/theaters?where=_ownerId%3D%22${id}%22&sortBy=_createdOn%20desc`,
//      getAll: '/data/theaters?sortBy=_createdOn%20desc&distinct=title',
//      create: '/data/theaters',
//      byId: '/data/theaters/',
//      del: '/data/theaters/',
//      edit: '/data/theaters/'

//  }
//  export async function getMyTheathers(id) {
//     return api.get(endpoints.myBooks(id))
// }

// // export async function getRecent() {
// //     return api.get(endpoints.recent)
// // }

// export async function getАll() {
//     return api.get(endpoints.getAll)
// }

// export async function create(data) {
//     return api.post(endpoints.create, data)
// }

// export async function getById(id) {
//     return api.get(endpoints.byId + id)
// }

// export async function deleteById(id) {
//     return api.del(endpoints.del + id)
// }
// export async function editById(id,data) {
//     return api.put(endpoints.edit + id,data)
// }



export function doLocalStorage() {

    const getDataFromStorage = function get<T>( key: string) {
        return JSON.parse(localStorage.getItem(key) ?? "") as T
    }

    const setDataToStorage = function set<T>(data: T, key: string) {
      localStorage.setItem(key,JSON.stringify(data))
    }

    return { getDataFromStorage,setDataToStorage }
}
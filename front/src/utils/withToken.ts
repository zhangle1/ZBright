import { CLAIM_TOKEN } from "@/const/claim"
import { doLocalStorage } from "./dolocalStorage"


export function withToken<T>(request: any): Promise<T> {
    const { getDataFromStorage } = doLocalStorage()
    const token = getDataFromStorage(CLAIM_TOKEN)
    const option = { Authorization: "Bearer " + token }
    return request(option)
}
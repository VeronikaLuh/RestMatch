import Bottleneck from "bottleneck";
import ApiErrorHandler from "../errorHandler/ApiErrorHandler";
import {HttpMethods} from "@/types/enum";
import axios from "axios";
import {ApiRequestOptions, HttpsRequestOptions} from "@/types/api";

const makeApiRequest = async (options: ApiRequestOptions, token?: string) => {
  const limiter = new Bottleneck({
    minTime: 1000,
  });
  const {url, method, body} = options;
  const headersParams: any = {
    'Content-Type': 'application/json',
  };

  if (token) {
    headersParams['Authorization'] = `Bearer ${token}`;
  }

  try {
    let response: any;
    await limiter.schedule(async () => {
      switch (method) {
        case HttpMethods.GET: {
          response = await axios.get(`${url}`, {
            headers: headersParams
          });
          break;
        }
        case HttpMethods.POST: {
          response = await axios.post(`${url}`, body, {
            headers: headersParams
          });
          break;
        }
        case HttpMethods.PATCH: {
          response = await axios.patch(`${url}`, body, {
            headers: headersParams
          });
          break;
        }
        case HttpMethods.DELETE: {
          response = await axios.delete(`${url}`, {
            headers: headersParams
          });
          break;
        }
      }
    });

    console.log('Backend response', response.data);
    return response.data;
  } catch (error: any) {
    ApiErrorHandler.handleError(error);
    throw error;
  }
}

const makeHttpsRequest = async (options: HttpsRequestOptions) => {
  const {req, res, url, method} = options;
  const headersParams: any = {
    'Content-Type': 'application/json',
    'Accept': '*/*'
  };

  const authHeader = req.headers.authorization;
  if (authHeader) {
    headersParams['Authorization'] = `${authHeader}`;
  }

  try {
    let response = await axios({
      method: method,
      url: url,
      headers: headersParams,
      ...(req.body && { data: req.body }),
      maxRedirects: 0,
    });

    console.log('Response from backend:', response.data);
    return res.status(response.status).json(response.data);
  } catch (error: any) {
    if (error.response && error.response.status === 302) {
      const redirectUrl = error.response.headers.location;

      const redirectResponse = await axios({
        method: method,
        url: redirectUrl,
        headers: headersParams,
        data: req.body,
      });

      return res.status(redirectResponse.status).json(redirectResponse.data);
    }

    console.error('Error from backend:', error);
    if (error.response) {
      return res.status(error.response.status).json({error: error.response.data});
    } else {
      return res.status(500).json({message: 'Internal Server Error'});
    }
  }
}

const apiService = {
  makeHttpsRequest,
  makeApiRequest
}


export default apiService;
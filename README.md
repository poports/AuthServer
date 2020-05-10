# AuthServer

Authentication using IdentityServer4

Curl: 
```
curl --location --request POST 'https://localhost:5001/api/accounts' \
--header 'Content-Type: application/json' \
--header 'Content-Type: application/json' \
--data-raw '{
	"fullName": "Test Employer",
	"email": "test@example.com",
	"password": "P@ssw0rd1",
	"role": "employer"
}'
```

Postman:
 Metod = Post
 Body = raw 

```
 {
	"fullName": "Test Employer",
	"email": "test@example.com",
	"password": "P@ssw0rd1",
	"role": "employer"
}
```


Test Url: https://localhost:5001/test-client/index.html
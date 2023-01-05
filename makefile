docker-dev-db-mssql-up:
	docker compose -f docker-compose.test.yml up --build -d

docker-dev-db-mssql-down:
	docker compose -f docker-compose.test.yml down

docker-dev-up:
	docker-compose -f docker-compose.develop.yml up --build

docker-dev-down:
	docker-compose -f docker-compose.develop.yml down


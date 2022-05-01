Before creating to environment, create a .devcontainer/.env file with the following variables:
```env
RABBITMQ_DEFAULT_USER=<some-string> 
RABBITMQ_DEFAULT_PASS=<some-string>
```
Rabbitmq definitions (queues, exchanges, binding, and more) are loaded from .devcontainer/rabbitmq/definitions.json
